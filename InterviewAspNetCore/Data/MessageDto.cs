namespace InterviewAspNetCore.Data;
public class MessageDto
{
	public string Message { get; set; }

	public SendType SendType { get; set; }

	/// <summary>
	/// Phone number or email
	/// </summary>
	public string SendTo { get; set; }
}			

public enum SendType
{
	Sms,
	Email
}