using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BuildPageObjects
{
    public class BuildPageObject
    {
        protected static IWebDriver driver;
        protected static String dashboardUrl;
        public Dictionary<string, Action<InputTag, StreamWriter>> InputTypes = new Dictionary<string, Action<InputTag, StreamWriter>>();

        public void SetInputTypes()
        {
            InputTypes.Add("text", InputText);
            InputTypes.Add("submit", InputSubmit);
            InputTypes.Add("checkbox", InputCheckRadio);
            InputTypes.Add("radio", InputCheckRadio);
            InputTypes.Add("password", InputText);
        }

        public BuildPageObject()
        {
            SetInputTypes();
        }

        [OneTimeSetUpAttribute]
        public void InitiateBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\SWW\\");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Url = ("http://ggibbons:Suzukig5xr750@wsddev.swwater.co.uk/");
            driver.Navigate().GoToUrl("http://wsddev.swwater.co.uk/_layouts/runTime.aspx?culture=en-GB&uiculture=en-US&workflowInstanceId=2670");
        }

        [OneTimeTearDownAttribute]
        public void FixtureTearDown()
        {
            if (driver != null)
                driver.Manage().Cookies.DeleteAllCookies();
            driver.Quit();
        }

        [Test]
        public void CreatePageObject()
        { 
            var links = new List<UrlLinks>();
            var inputs = new List<InputTag>();
            var selects = new List<SelectTag>();
            var buttons = new List<ButtonTag>();
            var forms = new List<FormTag>();


            var Links = driver.FindElements(By.TagName("a"));
            var Inputs = driver.FindElements(By.TagName("input"));
            var Selects = driver.FindElements(By.TagName("select"));
            var Buttons = driver.FindElements(By.TagName("button"));
            var Forms = driver.FindElements(By.TagName("form"));
            var file = new StreamWriter(@"E:\test.cs");

            GenerateDeclarations(Links, file, links, Inputs, inputs, Selects, selects, Buttons, buttons);
            GenerateSelectMethods(selects, file);
            GenerateInputMethods(file, inputs);
            GenerateGoToPageMethods(links, file);
            GenerateFormSubmissions(Forms, file, forms, selects, buttons);
            file.Close();
        }

        private void GenerateFormSubmissions(IEnumerable<IWebElement> Forms, StreamWriter file,
        List<FormTag> forms, List<SelectTag> selects,
        List<ButtonTag> buttons)
        {
            foreach (var formDetails in Forms.Select(form => new FormTag
            {
                Id = form.GetAttribute("id"),
                Method = form.GetAttribute("method"),
                Name = form.GetAttribute("name"),
                Action = form.GetAttribute("action")
            }))
            {
                forms.Add(formDetails);
            }
            foreach (var formstuff in Forms)
            {
                formstuff.FindElements(By.TagName("input"));
            }
        }

        private void GenerateSelectMethods(IEnumerable<SelectTag> selects, StreamWriter file)
        {
            file.Write("#region Select Methods\n");
            foreach (var selectTag in selects.Select(select => "\npublic void SelectOption" + select.Id + "(string optionToSelect)\n" +
            "{" +
            "\n\t SelectElement select = new SelectElement(_" + select.Id + ");" +
            "\n\t select.SelectByText(optionToSelect);" +
            "\n}\n"))
            {
                file.Write(selectTag);
            }
            file.Write("#endregion\n\n");
        }

        private void GenerateInputMethods(StreamWriter file, IEnumerable<InputTag> inputs)
        {
            file.Write("#region Input Methods\n");
            //generate input methods
            foreach (var input in inputs)
            {
                var inputType = input.Type;
                if (InputTypes.ContainsKey(inputType))
                    InputTypes[inputType].Invoke(input, file);
            }
            file.Write("#endregion\n\n");
        }

        private void InputText(InputTag text, StreamWriter file)
        {
            var inputMethod = "\npublic void PopulateInputField" + text.Id + "(string textToInput)\n" +
            "{" +
            "\n\t _" + text.Id + ".Clear();" +
            "\n\t _" + text.Id + ".SendKeys(textToInput);" +
            "\n" +
            "}\n";
            file.Write(inputMethod);
        }

        private void InputCheckRadio(InputTag submit, StreamWriter file)
        {
            var inputMethod = "\npublic void ClickCheckRadio" + submit.Id + "()\n" +
            "{" +
            "\n\t _" + submit.Id + ".Click();" +
            "\n" +
            "}\n";
            file.Write(inputMethod);
        }

        private void InputSubmit(InputTag submit, StreamWriter file)
        {
            var inputMethod = "\npublic UnknownObjectPage ClickSubmit" + submit.Id + "()\n" +
            "{" +
            "\n\t _" + submit.Id + ".Click();" +
            "\n\t return new UnknownObjectPage(_driver);" +
            "\n" +
            "}\n";
            file.Write(inputMethod);
        }

        private static void GenerateGoToPageMethods(IEnumerable<UrlLinks> links, StreamWriter file)
        {
            file.Write("#region GoToPage Methods\n");
            foreach (var goToMethods in links.Select(link => "\npublic " + RemoveSpecialCharacters(link.LinkText.Replace(" ", string.Empty)) + "Page GoTo" +
            RemoveSpecialCharacters(link.LinkText.Replace(" ", string.Empty)) + "Page()" +
            "\n{" +
            "\n\t_" + RemoveSpecialCharacters(link.LinkText.Replace(" ", string.Empty)) + ".Click();" +
            "\n\treturn new " + RemoveSpecialCharacters(link.LinkText.Replace(" ", string.Empty)) +
            "Page(_driver);" +
            "\n}" +
            "\n"))
            {
                file.Write(goToMethods);
            }
            file.Write("#endregion\n\n");
        }

        private static void GenerateDeclarations(IEnumerable<IWebElement> Links, StreamWriter file, List<UrlLinks> links,
        IEnumerable<IWebElement> Inputs, List<InputTag> inputs,
        IEnumerable<IWebElement> Selects, List<SelectTag> selects,
        IEnumerable<IWebElement> Buttons, List<ButtonTag> buttons)
        {
            file.Write("#region LinkElementDeclarations\n");
            foreach (var linkDetails in from webElement in Links
                                        where webElement.Text != string.Empty
                                        select new UrlLinks
                                            {
                                                Url = webElement.GetAttribute("href"),
                                                LinkText = webElement.Text,
                                                Declaration =
                                                "[FindsBy(How = How.LinkText, Using = \"" + webElement.Text + "\")] \nprivate IWebElement _" +
                                                RemoveSpecialCharacters(
                                                webElement.Text.ToLower()
                                                .Replace(" ", string.Empty)
                                                .Replace(Environment.NewLine, string.Empty)) + ";\n\n"
                                            })
            {
                file.Write(linkDetails.Declaration);
                links.Add(linkDetails);
            }
            file.Write("#endregion\n\n");
            file.Write("#region InputElementDeclarations\n");
            //inputs
            foreach (var inputDetails in Inputs.Select(input => new InputTag
            {
                Type = input.GetAttribute("type"),
                MaxLength = input.GetAttribute("maxlength"),
                Id = input.GetAttribute("id"),
                Class = input.GetAttribute("class"),
                Name = input.GetAttribute("name"),
                Declaration =
                "[FindsBy(How = How.Id, Using = \"" + input.GetAttribute("id") +
                "\")] \nprivate IWebElement _" +
                input.GetAttribute("id")
                .ToLower()
                .Replace(" ", string.Empty)
                .Replace(Environment.NewLine, string.Empty) + ";\n\n"
            }))
            {
                file.Write(inputDetails.Declaration);
                inputs.Add(inputDetails);
            }
            file.Write("#endregion\n\n");
            file.Write("#region SelectElementDeclarations\n");
            //selects
            foreach (var selectDetails in Selects.Select(select => new SelectTag
            {
                Id = select.GetAttribute("id"),
                Class = select.GetAttribute("class"),
                Declaration = "[FindsBy(How = How.Id, Using = \"" + select.GetAttribute("id") +
                "\")] \nprivate IWebElement _" +
                select.GetAttribute("id")
                .ToLower()
                .Replace(" ", string.Empty)
                .Replace(Environment.NewLine, string.Empty) + ";\n\n"
            }))
            {
                file.Write(selectDetails.Declaration);
                selects.Add(selectDetails);
            }
            file.Write("#endregion\n\n");
            file.Write("#region ButtonElementDeclarations\n");
            //buttons
            foreach (var buttonDetails in Buttons.Select(button => new ButtonTag
            {
                Id = button.GetAttribute("id"),
                Class = button.GetAttribute("class"),
                Type = button.GetAttribute("type"),
                Declaration = "[FindsBy(How = How.TagName, Using = \"button" +
                "\")] \nprivate IWebElement _button" +
                button.GetAttribute("id")
                .ToLower()
                .Replace(" ", string.Empty)
                .Replace(Environment.NewLine, string.Empty) + ";\n\n"
            }))
            {
                file.Write(buttonDetails.Declaration);
                buttons.Add(buttonDetails);
            }
            file.Write("#endregion\n\n");
        }

        public class UrlLinks
        {
            public string Url;
            public string LinkText;
            public string Declaration;
            public string Id;
            public string Name;
        }

        public class InputTag
        {
            public string Type;
            public string MaxLength;
            public string Id;
            public string Class;
            public string Name;
            public string Declaration;
        }

        public class SelectTag
        {
            public string Id;
            public string Class;
            public string Name;
            public string Declaration;
        }

        public class FormTag
        {
            public string Id;
            public string Method;
            public string Name;
            public string Action;
        }

        public class ButtonTag
        {
            public string Id;
            public string Class;
            public string Name;
            public string Type;
            public string Declaration;
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }
    }
}

