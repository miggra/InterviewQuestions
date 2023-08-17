namespace InterviewAspNetCore.Services
{
    public interface IMessageBuilder
    {
        public string SubstitudePlaceholders(string messageTemplate, Dictionary<string, string> substitutions)
    }
}
