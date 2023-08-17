namespace InterviewAspNetCore.Services
{
    public class MessageService
    {
        public MessageService() 
        {

        }
        public async Task Send()
        {
            Dictionary<string, string> tomData = new Dictionary<string, string>()
            {
                ["name"] = "Tom",
                ["city"] = "NewYork",
            };

            Dictionary<string, string> samData = new Dictionary<string, string>()
            {
                ["name"] = "Sam",
                ["city"] = "Washington",
            };
        }
    }
}
