﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Transmission.NetCore.Client.Models
{
    /// <summary>
    /// Absract class for arguments
    /// </summary>
    public abstract class ArgumentsBase
    {
        public Dictionary<string, object> ToDictionary()
        {
            var result = new Dictionary<string, object>();

            var type = GetType();
            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var propType = prop.PropertyType;

                var propJsonAttr = prop.CustomAttributes.FirstOrDefault(attr =>
                    attr.AttributeType == typeof(JsonPropertyAttribute));

                if (propJsonAttr == null)
                    continue;

                var propJsonAttrArg = propJsonAttr.ConstructorArguments.FirstOrDefault(arg => arg.Value != null);

                if (propJsonAttrArg == null)
                    continue;

                var argName = propJsonAttrArg.Value as string;
                var argValue = prop.GetValue(this);

                if (argValue == null)
                    continue;

                result.Add(argName, argValue);
            }

            return result;
        }
    }
}