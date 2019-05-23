using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Organizational
{
    /// <summary>
    /// An example derived organization class.
    /// </summary>
    public class ExampleOrganization : OrganizationBase
    {
        public static readonly string Name = "Example";
        public static readonly DirectoryName DirectoryName = new DirectoryName(ExampleOrganization.Name);


        public ExampleOrganization()
            : base(ExampleOrganization.Name, ExampleOrganization.DirectoryName)
        {
        }
    }
}
