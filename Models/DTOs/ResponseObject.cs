namespace HabariShopRU.API.Models.DTOs
{
    public class ResponseObject<T> where T : class
    {
        public string ResponseMessage { get; set; } = "Request Failed at this time!";
        public int ResponseCode { get; set; } = 99;
        public bool Status { get; set; } = false;
        public T? Data { get; set; }
    }
}
