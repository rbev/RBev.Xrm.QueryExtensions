namespace RBev.Xrm.QueryExtensions.UnitTests.Context.Model
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuserroles")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.0.0001.0061")]
    public partial class SystemUserRoles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUserRoles() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuserroles";

        public const int EntityTypeCode = 15;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public System.Nullable<System.Guid> RoleId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("roleid");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserroleid")]
        public System.Nullable<System.Guid> SystemUserRoleId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserroleid");
            }
            set
            {
                this.OnPropertyChanging("SystemUserRoleId");
                this.SetAttributeValue("systemuserroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserRoleId");
                if ((this._changedAttributes.Contains("systemuserroleid") == false))
                {
                    this._changedAttributes.Add("systemuserroleid");
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserroleid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserRoleId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// N:N systemuserroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserroles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuserroles_association
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("systemuserroles_association", null);
            }
            set
            {
                this.OnPropertyChanging("systemuserroles_association");
                this.SetRelatedEntities<SystemUser>("systemuserroles_association", null, value);
                this.OnPropertyChanged("systemuserroles_association");
            }
        }

        private System.Collections.Generic.List<string> _changedAttributes = new System.Collections.Generic.List<string>();

        public System.Collections.Generic.IList<string> ChangedAttributes
        {
            get
            {
                return this._changedAttributes.AsReadOnly();
            }
        }

        public void ClearChangedAttributes()
        {
            this._changedAttributes.Clear();
        }
    }
	
}