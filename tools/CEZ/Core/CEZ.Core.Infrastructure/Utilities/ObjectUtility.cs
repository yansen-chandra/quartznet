using CEZ.Core.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Utilities
{
    public static class ObjectUtility
    {
        /// <summary>
        /// To copy all property from source object to destination object
        /// Applicable for 
        /// - Exact same object type
        /// - Different object type, will copy property with same name
        /// - DIfferent object type, with copy property based on CEZ.Core.Infrastructure.Attributes.PropertyMapAttribute specified
        /// </summary>
        /// <param name="source">source object</param>
        /// <param name="target">target object</param>
        /// <param name="skipNullProperty"> [Optional] Set to TRUE to not copy null property from source entity, defaule : FALSE</param>
        public static void Copy(Object source, Object target, bool skipNullProperty = false)
        {
            if (source == target)
            {
                return;
            }

            foreach (PropertyInfo sourceProp in source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (sourceProp.PropertyType != typeof(byte[]) && sourceProp.PropertyType != typeof(string) &&
                    (sourceProp.PropertyType.IsClass || sourceProp.PropertyType.IsInterface))
                {
                    continue;
                }

                if (!sourceProp.CanWrite)
                {
                    continue;
                }

                if (sourceProp.GetCustomAttributes<KeyAttribute>(true).Any())
                {
                    continue;
                }

                //Set the value if object contain PropertyMapAttribute
                List<PropertyMapAttribute> mapAttrs = sourceProp.GetCustomAttributes<PropertyMapAttribute>().ToList();
                foreach (PropertyMapAttribute mapAttr in mapAttrs)
                {
                    if (target.GetType() == mapAttr.TargetPropertyType)
                    {
                        PropertyInfo targetProp = target.GetType().GetProperty(mapAttr.TargetPropertyName);
                        SetValue(targetProp, sourceProp, target, source, skipNullProperty);
                    }
                }

                //set the value if property have the same name
                PropertyInfo targetSameProp = target.GetType().GetProperty(sourceProp.Name);
                SetValue(targetSameProp, sourceProp, target, source, skipNullProperty);

            }

            foreach (FieldInfo f in source.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                if (f.FieldType != typeof(byte[]) && f.FieldType != typeof(string) &&
                    (f.FieldType.IsClass || f.FieldType.IsInterface))
                {
                    continue;
                }

                f.SetValue(target, f.GetValue(source));
            }
        }

        private static void SetValue(PropertyInfo targetProp, PropertyInfo sourceProp, Object target, object source, bool skipNullProperty)
        {
            if (targetProp != null)
            {
                object sourceValue = sourceProp.GetValue(source, null);
                if (sourceValue != null || !skipNullProperty)
                {
                    sourceValue = FormatValue(sourceValue, targetProp, sourceProp);
                    targetProp.SetValue(target, sourceValue, null);
                }
            }
        }

        private static object FormatValue(object value, PropertyInfo targetProp, PropertyInfo sourceProp)
        {
            if (targetProp.PropertyType == typeof(Boolean) || targetProp.PropertyType == typeof(Boolean?) ||
                targetProp.PropertyType == typeof(bool) || targetProp.PropertyType == typeof(bool?))
            {
                PropertyMapBooleanAttribute boolAttr = sourceProp.GetCustomAttribute<PropertyMapBooleanAttribute>();
                if (boolAttr != null)
                {
                    value = Convert.ToString(value) == boolAttr.TrueValue;
                }
            }
            else if (targetProp.PropertyType == typeof(DateTime) || targetProp.PropertyType == typeof(DateTime?))
            {
                PropertyMapDatetimeAttribute dtAttr = sourceProp.GetCustomAttribute<PropertyMapDatetimeAttribute>();
                if (dtAttr != null)
                {
                    value = DateTime.ParseExact(Convert.ToString(value), dtAttr.Format, CultureInfo.CurrentCulture);
                }
            }
            return value;
        }

        public static string GetProperty<T, P>(Expression<Func<T, P>> action) where T : class
        {
            var expression = (MemberExpression)action.Body;
            string name = expression.Member.Name;
            return name;
        }

    }

}
