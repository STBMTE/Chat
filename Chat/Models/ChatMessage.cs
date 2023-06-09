namespace Chat.Models
{
    public class ChatMessage
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public User Sender { get; set; }
        public Chatroom Chatroom { get; set; }
        public TimeSpan Date { get; set; }
    }
}