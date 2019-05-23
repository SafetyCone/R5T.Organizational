using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Organizational
{
    /// <summary>
    /// Represents a general organization.
    /// </summary>
    /// <remarks>
    /// Sealed, thus derive from <see cref="OrganizationBase"/> to create your own derived organizations.
    /// </remarks>
    public sealed class Organization : OrganizationBase
    {
        public Organization()
        {
        }

        public Organization(string name, DirectoryName directoryName)
            : base(name, directoryName)
        {
        }

        public Organization(string name, string directoryName)
            : base(name, directoryName)
        {
        }
    }
}
