namespace InterviewAspNetCore.Data;
class Message
{
    public Message(string recipient, string templateType, Dictionary<string, string> templateSubstitutions)
    {
        this.Recipient = recipient;
        this.TemplateType = templateType;
        this.TemplateSubstitutions = templateSubstitutions;
    }


    public string Recipient { get; set; }

    public string TemplateType { get; init; }

    public Dictionary<string, string> TemplateSubstitutions { get; init; }
}