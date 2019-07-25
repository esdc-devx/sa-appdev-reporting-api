namespace esdc_sa_appdev_reporting_api.Models
{
    public class TrelloActionDataDto
    {
        public TrelloActionDataCardDto card { get; set; }
        public TrelloActionDataListDto listAfter { get; set; }
        public TrelloActionDataListDto listBefore { get; set; }


        public TrelloActionDataDto()
        {
            card = new TrelloActionDataCardDto();
            listAfter = new TrelloActionDataListDto();
            listBefore = new TrelloActionDataListDto();
        }
    }
}