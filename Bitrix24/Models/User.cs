namespace Bitrix24.Models
{
    public class User
    {
        public string ID { get; set; }
        public string XML_ID { get; set; }
        public bool ACTIVE { get; set; }
        public string NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string LAST_LOGIN { get; set; }
        public string DATE_REGISTER { get; set; }
        public string IS_ONLINE { get; set; }
        public string TIME_ZONE_OFFSET { get; set; }
        public object TIMESTAMP_X { get; set; }
        public object LAST_ACTIVITY_DATE { get; set; }
        public string PERSONAL_GENDER { get; set; }
        public string PERSONAL_BIRTHDAY { get; set; }
        public string UF_EMPLOYMENT_DATE { get; set; }
        public List<int> UF_DEPARTMENT { get; set; }
        public string USER_TYPE { get; set; }
    }
}
