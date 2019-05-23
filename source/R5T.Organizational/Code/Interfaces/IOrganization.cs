using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Organizational
{
    /// <summary>
    /// Interface allowing manipulation of organization instances.
    /// </summary>
    /// <remarks>
    /// Organization classes will provide most of their functionality through static properties and methods. This allows syntax like "RivetOrganization.Name".
    /// However, organizations are also instantiable to allow manipulation of organization instances by client code.
    /// Note the "Organization" prefix for each property name. This allows the static properties of derived classes to use the property name, and allows instances to use syntax like rivet.OrganizationName.
    /// </remarks>
    public interface IOrganization
    {
        string OrganizationName { get; }
        DirectoryName OrganizationDirectoryName { get; }
    }
}
