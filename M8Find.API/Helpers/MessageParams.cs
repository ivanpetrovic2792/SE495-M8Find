namespace M8Find.API.Helpers
{
    public class MessageParams
    {
        private const int MaxPageSize = 50; // maximum number of page size user can set 
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; } // if user sets page size higher than maximum allowed, set it to max allowed
        }

        public int UserId { get; set; }
        public string MessageContainer { get; set; } = "Unread";
    }
}