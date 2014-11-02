using System;
using System.Reflection;

namespace TesteWebAPI.TiposAnonimos.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}