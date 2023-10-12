namespace InterviewAspNetCore.Data
{
    // not for change
    public class MessageTemplateProvider
    {
        public string GetMessagrTemplate(string template) => "Hello, %username%! What is the weather in %city%?";
    }
}
