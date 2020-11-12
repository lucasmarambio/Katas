using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Args.Domain
{
    public class Schema
    {
        private SchemaConfig _schema;

        public Schema()
        {
            _schema = LoadSchema();
        }

        private SchemaConfig LoadSchema()
        {
            using (StreamReader r = new StreamReader("Schemas//schemas.json"))
            {
                string json = r.ReadToEnd();
                return JsonSerializer.Deserialize<SchemaConfig>(json);
            }
        }

        public bool Validate(List<Command> commands)
        {
            return true;
        }

        public TypeEnum GetType(string flag)
        {
            return Enum.Parse<TypeEnum>(_schema.Required.First(x => x.FlagName == flag).Type);
        }
    }
}
