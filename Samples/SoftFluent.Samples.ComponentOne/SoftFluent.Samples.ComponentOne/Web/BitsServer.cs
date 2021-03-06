﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 06 October 2014 17:27. Build: 1.0.61214.0786
namespace SoftFluent.Samples.ComponentOne.Web
{
	
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    public partial class SoftFluent_Samples_ComponentOneBitsServer: CodeFluent.Runtime.BinaryServices.BitsServer
    {
		private static SoftFluent_Samples_ComponentOneBitsServer _current;

		public SoftFluent_Samples_ComponentOneBitsServer()
			:this(CodeFluent.Runtime.CodeFluentContext.Get(SoftFluent.Samples.ComponentOne.Constants.SoftFluent_Samples_ComponentOneStoreName))
		{
		}
		
		public SoftFluent_Samples_ComponentOneBitsServer(CodeFluent.Runtime.CodeFluentContext context)
			:base(context)
		{
		}

        protected override void OnInformation(object ctx)
        {
            if (ctx == null)
                throw new System.ArgumentNullException("ctx");
                
            System.Net.HttpListenerContext context = (System.Net.HttpListenerContext)ctx;
			string entityTypeName;
			string propertyName;
			string entityKey;
			ParseUri(context.Request.Url, out entityTypeName, out propertyName, out entityKey);
			
			if (entityTypeName == "SoftFluent.Samples.ComponentOne.User")
			{
				
				if (propertyName == "Photo")
				{
					SoftFluent.Samples.ComponentOne.User entity = SoftFluent.Samples.ComponentOne.User.LoadByEntityKey(entityKey);
					if (entity != null)
					{
						OnInformation(context, entity.Photo);
						return;
					}
					throw new System.InvalidOperationException(SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", new object[]{entityTypeName, entityKey}));
				}
				
			}
			
			throw new System.InvalidOperationException(SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", new object[]{context.Request.Url}));
        }

        protected override long OnDownload(object ctx, long start, long end)
        {
            if (ctx == null)
                throw new System.ArgumentNullException("ctx");
                
            System.Net.HttpListenerContext context = (System.Net.HttpListenerContext)ctx;
			string entityTypeName;
			string propertyName;
			string entityKey;
			ParseUri(context.Request.Url, out entityTypeName, out propertyName, out entityKey);
			
			if (entityTypeName == "SoftFluent.Samples.ComponentOne.User")
			{
				
				if (propertyName == "Photo")
				{
					SoftFluent.Samples.ComponentOne.User entity = SoftFluent.Samples.ComponentOne.User.LoadByEntityKey(entityKey);
					if (entity != null)
					{
						return OnDownload(context, entity.Photo, start, end);
					}
					throw new System.InvalidOperationException(SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", new object[]{entityTypeName, entityKey}));
				}
				
			}
			
			throw new System.InvalidOperationException(SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", new object[]{context.Request.Url}));
        }
		
		protected override void OnSessionClose(object ctx, CodeFluent.Runtime.BinaryServices.Session session)
        {
            if (ctx == null)
                throw new System.ArgumentNullException("ctx");

            if (session == null)
                throw new System.ArgumentNullException("session");

            if (!OnSessionChange(session, CodeFluent.Runtime.BinaryServices.SessionChangeType.Closing, ctx, true, null))
                return;

            System.Net.HttpListenerContext context = (System.Net.HttpListenerContext)ctx;
            
            string entityTypeName;
            string propertyName;
            string entityKey;
            ParseUri(context.Request.Url, out entityTypeName, out propertyName, out entityKey);
            OnSessionClose(context, session, entityTypeName, propertyName, entityKey);
            OnSessionChange(session, CodeFluent.Runtime.BinaryServices.SessionChangeType.Closed, ctx, false, null);
        }
        
        protected virtual void OnSessionClose(System.Net.HttpListenerContext context, CodeFluent.Runtime.BinaryServices.Session session, string entityTypeName, string propertyName, string entityKey)
        {
			
			if (entityTypeName == "SoftFluent.Samples.ComponentOne.User")
			{
				
				if (propertyName == "Photo")
				{
					SoftFluent.Samples.ComponentOne.User entity = SoftFluent.Samples.ComponentOne.User.LoadByEntityKey(entityKey);
					if (entity != null)
					{
						CloseSession(context, entity.Photo, session);
						return;
					}
				}
				
			}
			
			throw new System.InvalidOperationException(SoftFluent.Samples.ComponentOne.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", new object[]{context.Request.Url}));
        }

		public static SoftFluent_Samples_ComponentOneBitsServer Current
		{
			get
			{
				if (_current == null)
				{
					_current = new SoftFluent_Samples_ComponentOneBitsServer();
				}
				return _current;
			}
		}
    }
	
}
