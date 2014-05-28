﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 27 May 2014 10:59. Build: 1.0.61214.0769

namespace SoftFluent.Samples.Thinktecture.IdentityServer.Web.Security
{
	public partial class RoleStore : Microsoft.AspNet.Identity.IRoleStore<SoftFluent.Samples.Thinktecture.IdentityServer.Role, System.Guid>, Microsoft.AspNet.Identity.IRoleStore<SoftFluent.Samples.Thinktecture.IdentityServer.Role>
	{
        public System.Threading.Tasks.Task CreateAsync(SoftFluent.Samples.Thinktecture.IdentityServer.Role role)
        {
			if(role == null)
				throw new System.ArgumentNullException("role");

            return System.Threading.Tasks.Task.FromResult(role.Save());
        }

        public System.Threading.Tasks.Task UpdateAsync(SoftFluent.Samples.Thinktecture.IdentityServer.Role role)
        {
			if(role == null)
				throw new System.ArgumentNullException("role");

            return System.Threading.Tasks.Task.FromResult(role.Save());
        }

        public System.Threading.Tasks.Task DeleteAsync(SoftFluent.Samples.Thinktecture.IdentityServer.Role role)
        {
			if(role == null)
				throw new System.ArgumentNullException("role");

            return System.Threading.Tasks.Task.FromResult(role.Delete());
        }

        public System.Threading.Tasks.Task<SoftFluent.Samples.Thinktecture.IdentityServer.Role> FindByIdAsync(string roleId)
        {
            return System.Threading.Tasks.Task.FromResult(SoftFluent.Samples.Thinktecture.IdentityServer.Role.LoadByEntityKey(roleId));
        }
		
        public System.Threading.Tasks.Task<SoftFluent.Samples.Thinktecture.IdentityServer.Role> FindByIdAsync(System.Guid roleId)
        {
            return System.Threading.Tasks.Task.FromResult(SoftFluent.Samples.Thinktecture.IdentityServer.Role.Load(roleId));
        }
		
        public System.Threading.Tasks.Task<SoftFluent.Samples.Thinktecture.IdentityServer.Role> FindByNameAsync(string roleName)
        {
            return System.Threading.Tasks.Task.FromResult(SoftFluent.Samples.Thinktecture.IdentityServer.Role.LoadByName(roleName));
        }

		
		
        public void Dispose()
        {
        }
	}
}