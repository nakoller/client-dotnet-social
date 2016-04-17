using System;
using System.Reflection;

namespace YelpApi.Client.Extensions
{
  /// <summary>
  /// Extension methods to make it easy to determine if a type or property has a Custom attribute. 
  /// All this really does is attempts to get the attribute and checks if null.
  /// </summary>
  public static class ReflectionExtensions
  {
    /// <summary>
    /// Does this property have the specificed custom attribute?
    /// </summary>
    /// <typeparam name="T">The attribute to find</typeparam>
    /// <param name="propertyInfo">The property in question.</param>
    /// <returns>True if the attribute exists, False otherwise</returns>
    public static bool HasCustomAttribute<T>(this PropertyInfo propertyInfo) where T : Attribute
    {
      return propertyInfo.GetCustomAttribute<T>() != null;
    }

    /// <summary>
    /// Does this type have the specificed custom attribute?
    /// </summary>
    /// <typeparam name="T">The attribute to find</typeparam>
    /// <param name="type">The type in question.</param>
    /// <returns>True if the attribute exists, False otherwise</returns>
    public static bool HasCustomAttribute<T>(this Type type) where T : Attribute
    {
      return type.GetCustomAttribute<T>() != null;
    }
  }
}
