namespace Chat.Dtos
{
    public class MessageDTO
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public UserDto User { get; set; }
        public TimeSpan Date { get; set; }
    }
}
