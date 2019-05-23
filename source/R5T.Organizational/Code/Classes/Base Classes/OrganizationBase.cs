using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Organizational
{
    /// <summary>
    /// Base class for derived organization classes.
    /// </summary>
    public abstract class OrganizationBase : IOrganization
    {
        public string OrganizationName { get; set; }
        public DirectoryName OrganizationDirectoryName { get; set; }


        protected OrganizationBase()
        {
        }

        protected OrganizationBase(string name, DirectoryName directoryName)
        {
            this.OrganizationName = name;
            this.OrganizationDirectoryName = directoryName;
        }

        protected OrganizationBase(string name, string directoryName)
            : this(name, new DirectoryName(directoryName))
        {
        }
    }
}
