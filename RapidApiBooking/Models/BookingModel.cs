namespace RapidApiBooking.Models
{
    public class BookingModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public int hotel_id { get; set; }
        public string accessibilityLabel { get; set; }
        public string wishlistName { get; set; }
        public string countryCode { get; set; }
        public int optOutFromGalleryChanges { get; set; }
        public int accuratePropertyClass { get; set; }
        public float latitude { get; set; }
        public int reviewCount { get; set; }
        public string checkinDate { get; set; }
        public int ufi { get; set; }
        public int position { get; set; }
        public string[] blockIds { get; set; }
        public string checkoutDate { get; set; }
        public string currency { get; set; }
        public int qualityClass { get; set; }
        public float longitude { get; set; }
        public string reviewScoreWord { get; set; }
        public string name { get; set; }
        public float reviewScore { get; set; }
        public int mainPhotoId { get; set; }
        public bool isPreferred { get; set; }
        public int propertyClass { get; set; }
        public int id { get; set; }
        public string[] photoUrls { get; set; }
        public bool isPreferredPlus { get; set; }
        public bool isFirstPage { get; set; }
        public int rankingPosition { get; set; }
        public object[] taxExceptions { get; set; }
        public float value { get; set; }
        public string explanation { get; set; }
        public string identifier { get; set; }
        public string variant { get; set; }
        public string text { get; set; }
        public string fromTime { get; set; }
        public string untilTime { get; set; }
        public string title { get; set; }
        public bool fitContentWidth { get; set; }
        public string spacing { get; set; }
        public string tertiaryTintedColor { get; set; }
        public string icon { get; set; }
        public string font { get; set; }
        public string color { get; set; }
        public string url { get; set; }
    }
}
