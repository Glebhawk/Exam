using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainBattleProject3.IoC
{
    public static class IoCContainer
    {
        private static readonly Dictionary<Type, Type> registeredObjects = new Dictionary<Type, Type>();

        public static void RegisterObject<TypeToRegister, ConcreteType>()
        {
            registeredObjects.Add(typeof(TypeToRegister), typeof(ConcreteType));
        }

        public static dynamic ResolveObject(Type typeToResolve, IEnumerable<object> parameters)
        {
            Type resolvedType;
            registeredObjects.TryGetValue(typeToResolve, out resolvedType);
            if (resolvedType == null)
            {
                object[] parametersArray = parameters.ToArray();
                return Activator.CreateInstance(typeToResolve, parametersArray);
            }

            object[] param = parameters.ToArray();
            return Activator.CreateInstance(resolvedType, param);
        }
    }
}
