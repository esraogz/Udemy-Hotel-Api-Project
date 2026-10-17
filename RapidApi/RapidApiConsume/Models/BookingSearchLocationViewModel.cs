namespace RapidApiConsume.Models
{
    public class BookingSearchLocationViewModel
    {
        public Datum[] data { get; set; }

        public class Datum
        {
            public string dest_id { get; set; }
        }

    }
}
