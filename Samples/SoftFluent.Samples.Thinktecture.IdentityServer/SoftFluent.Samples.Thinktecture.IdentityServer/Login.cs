﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.Thinktecture.IdentityServer
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 27 May 2014 10:59.
    // Build:1.0.61214.0769
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0769")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, ProviderName={ProviderName}, Id={Id}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class Login : System.ICloneable, System.IComparable, System.IComparable<SoftFluent.Samples.Thinktecture.IdentityServer.Login>, CodeFluent.Runtime.ICodeFluentCollectionEntity<System.Guid>, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<SoftFluent.Samples.Thinktecture.IdentityServer.Login>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private byte[] _rowVersion;
        
        private System.Guid _id = CodeFluentPersistence.DefaultGuidValue;
        
        private string _providerName = default(string);
        
        private string _providerKey = default(string);
        
        private System.Guid _userId = CodeFluentPersistence.DefaultGuidValue;
        
        [System.NonSerializedAttribute()]
        private SoftFluent.Samples.Thinktecture.IdentityServer.User _user = null;
        
        public Login()
        {
            this._id = System.Guid.NewGuid();
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.Id.ToString();
            }
            set
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(value, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.ProviderName;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(false, true)]
        [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.ByteArrayConverter))]
        public byte[] RowVersion
        {
            get
            {
                return this._rowVersion;
            }
            set
            {
                if (((value != null) 
                            && (value.Length == 0)))
                {
                    value = null;
                }
                this._rowVersion = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RowVersion"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this._id) == true))
                {
                    return;
                }
                System.Guid oldKey = this._id;
                if ((value.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
                    this._id = System.Guid.NewGuid();
                }
                else
                {
                    this._id = value;
                }
                try
                {
                    this.OnCollectionKeyChanged(oldKey);
                }
                catch (System.ArgumentException )
                {
                    this._id = oldKey;
                    return;
                }
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string ProviderName
        {
            get
            {
                return this._providerName;
            }
            set
            {
                this._providerName = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProviderName"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string ProviderKey
        {
            get
            {
                return this._providerKey;
            }
            set
            {
                this._providerKey = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProviderKey"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid UserId
        {
            get
            {
                if (((this._userId.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                            && (this._user != null)))
                {
                    this._userId = this._user.Id;
                }
                return this._userId;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this.UserId) == true))
                {
                    return;
                }
                this._user = null;
                this._userId = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("User"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("UserId"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftFluent.Samples.Thinktecture.IdentityServer.User User
        {
            get
            {
                if ((this._user == null))
                {
                    this._user = SoftFluent.Samples.Thinktecture.IdentityServer.User.Load(this._userId);
                }
                return this._user;
            }
            set
            {
                this._userId = CodeFluentPersistence.DefaultGuidValue;
                this._user = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("User"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("UserId"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        System.Guid CodeFluent.Runtime.Utilities.IKeyable<System.Guid>.Key
        {
            get
            {
                return this.Id;
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.Created) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        [field:System.NonSerializedAttribute()]
        public event System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>> KeyChanged;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(SoftFluent.Samples.Thinktecture.IdentityServer.Login login)
        {
            if ((login == null))
            {
                return false;
            }
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return base.Equals(login);
            }
            return (this.Id.Equals(login.Id) == true);
        }
        
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            SoftFluent.Samples.Thinktecture.IdentityServer.Login login = null;
			login = obj as SoftFluent.Samples.Thinktecture.IdentityServer.Login;
            return this.Equals(login);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            SoftFluent.Samples.Thinktecture.IdentityServer.Login login = null;
login = value as SoftFluent.Samples.Thinktecture.IdentityServer.Login;
            if ((login == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(login);
            return localCompareTo;
        }
        
        public virtual int CompareTo(SoftFluent.Samples.Thinktecture.IdentityServer.Login login)
        {
            if ((login == null))
            {
                throw new System.ArgumentNullException("login");
            }
            int localCompareTo = this.Id.CompareTo(login.Id);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = SoftFluent.Samples.Thinktecture.IdentityServer.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.Thinktecture.IdentityServer.Login.ExternalValidate", "Type \'SoftFluent.Samples.Thinktecture.IdentityServer.Login\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                string localValidate = SoftFluent.Samples.Thinktecture.IdentityServer.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.Thinktecture.IdentityServer.Login.Id.NullException", "\'Id\' property cannot be set to \'00000000-0000-0000-0000-000000000000\' for type \'S" +
                        "oftFluent.Samples.Thinktecture.IdentityServer.Login\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate);
            }
            if ((this.ProviderName == default(string)))
            {
                string localValidate1 = SoftFluent.Samples.Thinktecture.IdentityServer.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.Thinktecture.IdentityServer.Login.ProviderName.NullException", "\'ProviderName\' property cannot be set to \'\' for type \'SoftFluent.Samples.Thinktec" +
                        "ture.IdentityServer.Login\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate1);
            }
            if ((this.ProviderKey == default(string)))
            {
                string localValidate2 = SoftFluent.Samples.Thinktecture.IdentityServer.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.Thinktecture.IdentityServer.Login.ProviderKey.NullException", "\'ProviderKey\' property cannot be set to \'\' for type \'SoftFluent.Samples.Thinktect" +
                        "ure.IdentityServer.Login\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate2);
            }
            if ((this.User == null))
            {
                string localValidate3 = SoftFluent.Samples.Thinktecture.IdentityServer.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.Thinktecture.IdentityServer.Login.User.NullException", "\'User\' property cannot be set to \'\' for type \'SoftFluent.Samples.Thinktecture.Ide" +
                        "ntityServer.Login\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate3);
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            if ((this.RowVersion == null))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.Thinktecture.IdentityServer.Constants.SoftFluent_Samples_Thinktecture_IdentityServerStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Login", "Delete");
            persistence.AddParameter("@Login_Id", this.Id, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._id = CodeFluentPersistence.GetReaderValue(reader, "Login_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this._providerName = CodeFluentPersistence.GetReaderValue(reader, "Login_ProviderName", ((string)(default(string))));
                this._providerKey = CodeFluentPersistence.GetReaderValue(reader, "Login_ProviderKey", ((string)(default(string))));
                this.UserId = CodeFluentPersistence.GetReaderValue(reader, "Login_User_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.RowVersion) 
                        == 0) 
                        == false))
            {
                this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.Thinktecture.IdentityServer.Login Load(System.Guid id)
        {
            if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.Thinktecture.IdentityServer.Login login = new SoftFluent.Samples.Thinktecture.IdentityServer.Login();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.Thinktecture.IdentityServer.Constants.SoftFluent_Samples_Thinktecture_IdentityServerStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Login", "Load");
            persistence.AddParameter("@Id", id, CodeFluentPersistence.DefaultGuidValue);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    login.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    login.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return login;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
        public static SoftFluent.Samples.Thinktecture.IdentityServer.Login LoadById(System.Guid id)
        {
            if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.Thinktecture.IdentityServer.Login login = new SoftFluent.Samples.Thinktecture.IdentityServer.Login();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.Thinktecture.IdentityServer.Constants.SoftFluent_Samples_Thinktecture_IdentityServerStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Login", "LoadById");
            persistence.AddParameter("@Id", id, CodeFluentPersistence.DefaultGuidValue);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    login.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    login.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return login;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.Thinktecture.IdentityServer.Constants.SoftFluent_Samples_Thinktecture_IdentityServerStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Login", "Load");
            persistence.AddParameter("@Id", this.Id);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.Thinktecture.IdentityServer.Constants.SoftFluent_Samples_Thinktecture_IdentityServerStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Login", "Save");
            persistence.AddParameter("@Login_Id", this.Id, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@Login_ProviderName", this.ProviderName, default(string));
            persistence.AddParameter("@Login_ProviderKey", this.ProviderKey, default(string));
            persistence.AddParameter("@Login_User_Id", this.UserId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Samples.Thinktecture.IdentityServer.Login login)
        {
            if ((login == null))
            {
                return false;
            }
            bool ret = login.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Samples.Thinktecture.IdentityServer.Login login)
        {
            bool ret = SoftFluent.Samples.Thinktecture.IdentityServer.Login.Save(login);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Samples.Thinktecture.IdentityServer.Login login)
        {
            if ((login == null))
            {
                return false;
            }
            bool ret = login.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("Id=");
            writer.Write(this.Id);
            writer.Write(",");
            writer.Write("ProviderName=");
            writer.Write(this.ProviderName);
            writer.Write(",");
            writer.Write("ProviderKey=");
            writer.Write(this.ProviderKey);
            writer.Write(",");
            writer.Write("User=");
            if ((this._user != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._user)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_userId=");
            writer.Write(this._userId);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.Thinktecture.IdentityServer.Login LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            SoftFluent.Samples.Thinktecture.IdentityServer.Login login;
            System.Guid var = ((System.Guid)(ConvertUtilities.ChangeType(key, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            login = SoftFluent.Samples.Thinktecture.IdentityServer.Login.Load(var);
            return login;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public SoftFluent.Samples.Thinktecture.IdentityServer.Login Clone(bool deep)
        {
            SoftFluent.Samples.Thinktecture.IdentityServer.Login login = new SoftFluent.Samples.Thinktecture.IdentityServer.Login();
            this.CopyTo(login, deep);
            return login;
        }
        
        public SoftFluent.Samples.Thinktecture.IdentityServer.Login Clone()
        {
            SoftFluent.Samples.Thinktecture.IdentityServer.Login localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("Id") == true))
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(dict["Id"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("ProviderKey") == true))
            {
                this.ProviderKey = ((string)(ConvertUtilities.ChangeType(dict["ProviderKey"], typeof(string), default(string))));
            }
            if ((dict.Contains("ProviderName") == true))
            {
                this.ProviderName = ((string)(ConvertUtilities.ChangeType(dict["ProviderName"], typeof(string), default(string))));
            }
            if ((dict.Contains("UserId") == true))
            {
                this.UserId = ((System.Guid)(ConvertUtilities.ChangeType(dict["UserId"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(SoftFluent.Samples.Thinktecture.IdentityServer.Login login, bool deep)
        {
            if ((login == null))
            {
                throw new System.ArgumentNullException("login");
            }
            login.Id = this.Id;
            login.ProviderKey = this.ProviderKey;
            login.ProviderName = this.ProviderName;
            login.UserId = this.UserId;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, login));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["Id"] = this.Id;
            dict["ProviderKey"] = this.ProviderKey;
            dict["ProviderName"] = this.ProviderName;
            dict["UserId"] = this.UserId;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
        
        protected void OnCollectionKeyChanged(System.Guid key)
        {
            if ((this.KeyChanged != null))
            {
                this.KeyChanged(this, new CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>(key));
            }
        }
    }
}
