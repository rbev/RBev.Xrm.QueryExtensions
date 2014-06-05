namespace RBev.Xrm.QueryExtensions.UnitTests.Context.Model
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuserprofiles")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.0.0001.0061")]
    public partial class SystemUserProfiles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUserProfiles() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuserprofiles";

        public const int EntityTypeCode = 1202;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
        public System.Nullable<System.Guid> FieldSecurityProfileId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldsecurityprofileid");
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserprofileid")]
        public System.Nullable<System.Guid> SystemUserProfileId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserprofileid");
            }
            set
            {
                this.OnPropertyChanging("SystemUserProfileId");
                this.SetAttributeValue("systemuserprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserProfileId");
                if ((this._changedAttributes.Contains("systemuserprofileid") == false))
                {
                    this._changedAttributes.Add("systemuserprofileid");
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserprofileid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserProfileId = value;
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
        /// N:N systemuserprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserprofiles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuserprofiles_association
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("systemuserprofiles_association", null);
            }
            set
            {
                this.OnPropertyChanging("systemuserprofiles_association");
                this.SetRelatedEntities<SystemUser>("systemuserprofiles_association", null, value);
                this.OnPropertyChanged("systemuserprofiles_association");
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