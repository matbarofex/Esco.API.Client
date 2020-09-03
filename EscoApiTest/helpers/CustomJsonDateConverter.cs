using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace EscoApiTest.Settings
{
    public class CustomJsonDateTimeConverter: IsoDateTimeConverter
    {
        public CustomJsonDateTimeConverter() {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }

    public class CustomJsonDateConverter : IsoDateTimeConverter {
        public CustomJsonDateConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var data = base.ReadJson(reader, objectType, existingValue, serializer);
            DateTime dateTimeValue = Convert.ToDateTime( data);
            //if (dateTimeValue.ha)
            //{
            //    //TODO
            //}

            return dateTimeValue.Date;
        }


    }
}
