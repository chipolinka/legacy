using System;

namespace Legacy.Emails
{
	public class EmailSender : IEmailSender
	{
		public void SendMessage(EmailMessage message)
		{
			// ��� ���, ������� ������ ��������� �������� � �������� ���������.
			throw new Exception("EmailSender is not configured");
		}

		public string MailServer { get { throw new Exception("EmailSender is not configured"); }}
	}
}