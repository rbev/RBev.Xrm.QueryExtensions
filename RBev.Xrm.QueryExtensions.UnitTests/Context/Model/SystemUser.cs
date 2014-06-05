namespace RBev.Xrm.QueryExtensions.UnitTests.Context.Model
{
    /// <summary>
    /// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.0.0001.0061")]
    public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUser() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuser";

        public const int EntityTypeCode = 8;

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
        /// Unique identifier for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
            }
            set
            {
                this.OnPropertyChanging("Address1_AddressId");
                this.SetAttributeValue("address1_addressid", value);
                this.OnPropertyChanged("Address1_AddressId");
                if ((this._changedAttributes.Contains("address1_addressid") == false))
                {
                    this._changedAttributes.Add("address1_addressid");
                }
            }
        }

        /// <summary>
        /// City name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            get
            {
                return this.GetAttributeValue<string>("address1_city");
            }
            set
            {
                this.OnPropertyChanging("Address1_City");
                this.SetAttributeValue("address1_city", value);
                this.OnPropertyChanged("Address1_City");
                if ((this._changedAttributes.Contains("address1_city") == false))
                {
                    this._changedAttributes.Add("address1_city");
                }
            }
        }

        /// <summary>
        /// Shows the complete primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
        public string Address1_Composite
        {
            get
            {
                return this.GetAttributeValue<string>("address1_composite");
            }
        }

        /// <summary>
        /// Country/region name in address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address1_country");
            }
            set
            {
                this.OnPropertyChanging("Address1_Country");
                this.SetAttributeValue("address1_country", value);
                this.OnPropertyChanged("Address1_Country");
                if ((this._changedAttributes.Contains("address1_country") == false))
                {
                    this._changedAttributes.Add("address1_country");
                }
            }
        }

        /// <summary>
        /// County name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            get
            {
                return this.GetAttributeValue<string>("address1_county");
            }
            set
            {
                this.OnPropertyChanging("Address1_County");
                this.SetAttributeValue("address1_county", value);
                this.OnPropertyChanged("Address1_County");
                if ((this._changedAttributes.Contains("address1_county") == false))
                {
                    this._changedAttributes.Add("address1_county");
                }
            }
        }

        /// <summary>
        /// Fax number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address1_fax");
            }
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
                if ((this._changedAttributes.Contains("address1_fax") == false))
                {
                    this._changedAttributes.Add("address1_fax");
                }
            }
        }

        /// <summary>
        /// Latitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
            }
            set
            {
                this.OnPropertyChanging("Address1_Latitude");
                this.SetAttributeValue("address1_latitude", value);
                this.OnPropertyChanged("Address1_Latitude");
                if ((this._changedAttributes.Contains("address1_latitude") == false))
                {
                    this._changedAttributes.Add("address1_latitude");
                }
            }
        }

        /// <summary>
        /// First line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line1");
            }
            set
            {
                this.OnPropertyChanging("Address1_Line1");
                this.SetAttributeValue("address1_line1", value);
                this.OnPropertyChanged("Address1_Line1");
                if ((this._changedAttributes.Contains("address1_line1") == false))
                {
                    this._changedAttributes.Add("address1_line1");
                }
            }
        }

        /// <summary>
        /// Second line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line2");
            }
            set
            {
                this.OnPropertyChanging("Address1_Line2");
                this.SetAttributeValue("address1_line2", value);
                this.OnPropertyChanged("Address1_Line2");
                if ((this._changedAttributes.Contains("address1_line2") == false))
                {
                    this._changedAttributes.Add("address1_line2");
                }
            }
        }

        /// <summary>
        /// Third line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line3");
            }
            set
            {
                this.OnPropertyChanging("Address1_Line3");
                this.SetAttributeValue("address1_line3", value);
                this.OnPropertyChanged("Address1_Line3");
                if ((this._changedAttributes.Contains("address1_line3") == false))
                {
                    this._changedAttributes.Add("address1_line3");
                }
            }
        }

        /// <summary>
        /// Longitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
            }
            set
            {
                this.OnPropertyChanging("Address1_Longitude");
                this.SetAttributeValue("address1_longitude", value);
                this.OnPropertyChanged("Address1_Longitude");
                if ((this._changedAttributes.Contains("address1_longitude") == false))
                {
                    this._changedAttributes.Add("address1_longitude");
                }
            }
        }

        /// <summary>
        /// Name to enter for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address1_name");
            }
            set
            {
                this.OnPropertyChanging("Address1_Name");
                this.SetAttributeValue("address1_name", value);
                this.OnPropertyChanged("Address1_Name");
                if ((this._changedAttributes.Contains("address1_name") == false))
                {
                    this._changedAttributes.Add("address1_name");
                }
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postalcode");
            }
            set
            {
                this.OnPropertyChanging("Address1_PostalCode");
                this.SetAttributeValue("address1_postalcode", value);
                this.OnPropertyChanged("Address1_PostalCode");
                if ((this._changedAttributes.Contains("address1_postalcode") == false))
                {
                    this._changedAttributes.Add("address1_postalcode");
                }
            }
        }

        /// <summary>
        /// Post office box number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postofficebox");
            }
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
                if ((this._changedAttributes.Contains("address1_postofficebox") == false))
                {
                    this._changedAttributes.Add("address1_postofficebox");
                }
            }
        }

        /// <summary>
        /// State or province for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address1_stateorprovince");
            }
            set
            {
                this.OnPropertyChanging("Address1_StateOrProvince");
                this.SetAttributeValue("address1_stateorprovince", value);
                this.OnPropertyChanged("Address1_StateOrProvince");
                if ((this._changedAttributes.Contains("address1_stateorprovince") == false))
                {
                    this._changedAttributes.Add("address1_stateorprovince");
                }
            }
        }

        /// <summary>
        /// First telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone1");
            }
            set
            {
                this.OnPropertyChanging("Address1_Telephone1");
                this.SetAttributeValue("address1_telephone1", value);
                this.OnPropertyChanged("Address1_Telephone1");
                if ((this._changedAttributes.Contains("address1_telephone1") == false))
                {
                    this._changedAttributes.Add("address1_telephone1");
                }
            }
        }

        /// <summary>
        /// Second telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone2");
            }
            set
            {
                this.OnPropertyChanging("Address1_Telephone2");
                this.SetAttributeValue("address1_telephone2", value);
                this.OnPropertyChanged("Address1_Telephone2");
                if ((this._changedAttributes.Contains("address1_telephone2") == false))
                {
                    this._changedAttributes.Add("address1_telephone2");
                }
            }
        }

        /// <summary>
        /// Third telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone3");
            }
            set
            {
                this.OnPropertyChanging("Address1_Telephone3");
                this.SetAttributeValue("address1_telephone3", value);
                this.OnPropertyChanged("Address1_Telephone3");
                if ((this._changedAttributes.Contains("address1_telephone3") == false))
                {
                    this._changedAttributes.Add("address1_telephone3");
                }
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address1_upszone");
            }
            set
            {
                this.OnPropertyChanging("Address1_UPSZone");
                this.SetAttributeValue("address1_upszone", value);
                this.OnPropertyChanged("Address1_UPSZone");
                if ((this._changedAttributes.Contains("address1_upszone") == false))
                {
                    this._changedAttributes.Add("address1_upszone");
                }
            }
        }

        /// <summary>
        /// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
            }
            set
            {
                this.OnPropertyChanging("Address1_UTCOffset");
                this.SetAttributeValue("address1_utcoffset", value);
                this.OnPropertyChanged("Address1_UTCOffset");
                if ((this._changedAttributes.Contains("address1_utcoffset") == false))
                {
                    this._changedAttributes.Add("address1_utcoffset");
                }
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
            }
            set
            {
                this.OnPropertyChanging("Address2_AddressId");
                this.SetAttributeValue("address2_addressid", value);
                this.OnPropertyChanged("Address2_AddressId");
                if ((this._changedAttributes.Contains("address2_addressid") == false))
                {
                    this._changedAttributes.Add("address2_addressid");
                }
            }
        }

        /// <summary>
        /// City name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            get
            {
                return this.GetAttributeValue<string>("address2_city");
            }
            set
            {
                this.OnPropertyChanging("Address2_City");
                this.SetAttributeValue("address2_city", value);
                this.OnPropertyChanged("Address2_City");
                if ((this._changedAttributes.Contains("address2_city") == false))
                {
                    this._changedAttributes.Add("address2_city");
                }
            }
        }

        /// <summary>
        /// Shows the complete secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
        public string Address2_Composite
        {
            get
            {
                return this.GetAttributeValue<string>("address2_composite");
            }
        }

        /// <summary>
        /// Country/region name in address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address2_country");
            }
            set
            {
                this.OnPropertyChanging("Address2_Country");
                this.SetAttributeValue("address2_country", value);
                this.OnPropertyChanged("Address2_Country");
                if ((this._changedAttributes.Contains("address2_country") == false))
                {
                    this._changedAttributes.Add("address2_country");
                }
            }
        }

        /// <summary>
        /// County name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            get
            {
                return this.GetAttributeValue<string>("address2_county");
            }
            set
            {
                this.OnPropertyChanging("Address2_County");
                this.SetAttributeValue("address2_county", value);
                this.OnPropertyChanged("Address2_County");
                if ((this._changedAttributes.Contains("address2_county") == false))
                {
                    this._changedAttributes.Add("address2_county");
                }
            }
        }

        /// <summary>
        /// Fax number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address2_fax");
            }
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
                if ((this._changedAttributes.Contains("address2_fax") == false))
                {
                    this._changedAttributes.Add("address2_fax");
                }
            }
        }

        /// <summary>
        /// Latitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
            }
            set
            {
                this.OnPropertyChanging("Address2_Latitude");
                this.SetAttributeValue("address2_latitude", value);
                this.OnPropertyChanged("Address2_Latitude");
                if ((this._changedAttributes.Contains("address2_latitude") == false))
                {
                    this._changedAttributes.Add("address2_latitude");
                }
            }
        }

        /// <summary>
        /// First line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line1");
            }
            set
            {
                this.OnPropertyChanging("Address2_Line1");
                this.SetAttributeValue("address2_line1", value);
                this.OnPropertyChanged("Address2_Line1");
                if ((this._changedAttributes.Contains("address2_line1") == false))
                {
                    this._changedAttributes.Add("address2_line1");
                }
            }
        }

        /// <summary>
        /// Second line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line2");
            }
            set
            {
                this.OnPropertyChanging("Address2_Line2");
                this.SetAttributeValue("address2_line2", value);
                this.OnPropertyChanged("Address2_Line2");
                if ((this._changedAttributes.Contains("address2_line2") == false))
                {
                    this._changedAttributes.Add("address2_line2");
                }
            }
        }

        /// <summary>
        /// Third line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line3");
            }
            set
            {
                this.OnPropertyChanging("Address2_Line3");
                this.SetAttributeValue("address2_line3", value);
                this.OnPropertyChanged("Address2_Line3");
                if ((this._changedAttributes.Contains("address2_line3") == false))
                {
                    this._changedAttributes.Add("address2_line3");
                }
            }
        }

        /// <summary>
        /// Longitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
            }
            set
            {
                this.OnPropertyChanging("Address2_Longitude");
                this.SetAttributeValue("address2_longitude", value);
                this.OnPropertyChanged("Address2_Longitude");
                if ((this._changedAttributes.Contains("address2_longitude") == false))
                {
                    this._changedAttributes.Add("address2_longitude");
                }
            }
        }

        /// <summary>
        /// Name to enter for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address2_name");
            }
            set
            {
                this.OnPropertyChanging("Address2_Name");
                this.SetAttributeValue("address2_name", value);
                this.OnPropertyChanged("Address2_Name");
                if ((this._changedAttributes.Contains("address2_name") == false))
                {
                    this._changedAttributes.Add("address2_name");
                }
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postalcode");
            }
            set
            {
                this.OnPropertyChanging("Address2_PostalCode");
                this.SetAttributeValue("address2_postalcode", value);
                this.OnPropertyChanged("Address2_PostalCode");
                if ((this._changedAttributes.Contains("address2_postalcode") == false))
                {
                    this._changedAttributes.Add("address2_postalcode");
                }
            }
        }

        /// <summary>
        /// Post office box number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postofficebox");
            }
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
                if ((this._changedAttributes.Contains("address2_postofficebox") == false))
                {
                    this._changedAttributes.Add("address2_postofficebox");
                }
            }
        }

        /// <summary>
        /// State or province for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address2_stateorprovince");
            }
            set
            {
                this.OnPropertyChanging("Address2_StateOrProvince");
                this.SetAttributeValue("address2_stateorprovince", value);
                this.OnPropertyChanged("Address2_StateOrProvince");
                if ((this._changedAttributes.Contains("address2_stateorprovince") == false))
                {
                    this._changedAttributes.Add("address2_stateorprovince");
                }
            }
        }

        /// <summary>
        /// First telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone1");
            }
            set
            {
                this.OnPropertyChanging("Address2_Telephone1");
                this.SetAttributeValue("address2_telephone1", value);
                this.OnPropertyChanged("Address2_Telephone1");
                if ((this._changedAttributes.Contains("address2_telephone1") == false))
                {
                    this._changedAttributes.Add("address2_telephone1");
                }
            }
        }

        /// <summary>
        /// Second telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone2");
            }
            set
            {
                this.OnPropertyChanging("Address2_Telephone2");
                this.SetAttributeValue("address2_telephone2", value);
                this.OnPropertyChanged("Address2_Telephone2");
                if ((this._changedAttributes.Contains("address2_telephone2") == false))
                {
                    this._changedAttributes.Add("address2_telephone2");
                }
            }
        }

        /// <summary>
        /// Third telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone3");
            }
            set
            {
                this.OnPropertyChanging("Address2_Telephone3");
                this.SetAttributeValue("address2_telephone3", value);
                this.OnPropertyChanged("Address2_Telephone3");
                if ((this._changedAttributes.Contains("address2_telephone3") == false))
                {
                    this._changedAttributes.Add("address2_telephone3");
                }
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address2_upszone");
            }
            set
            {
                this.OnPropertyChanging("Address2_UPSZone");
                this.SetAttributeValue("address2_upszone", value);
                this.OnPropertyChanged("Address2_UPSZone");
                if ((this._changedAttributes.Contains("address2_upszone") == false))
                {
                    this._changedAttributes.Add("address2_upszone");
                }
            }
        }

        /// <summary>
        /// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
            }
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
                if ((this._changedAttributes.Contains("address2_utcoffset") == false))
                {
                    this._changedAttributes.Add("address2_utcoffset");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
            }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
                if ((this._changedAttributes.Contains("businessunitid") == false))
                {
                    this._changedAttributes.Add("businessunitid");
                }
            }
        }

        /// <summary>
        /// Fiscal calendar associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public Microsoft.Xrm.Sdk.EntityReference CalendarId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
            }
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
                if ((this._changedAttributes.Contains("calendarid") == false))
                {
                    this._changedAttributes.Add("calendarid");
                }
            }
        }
        
        /// <summary>
        /// Unique identifier of the user who created the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the user was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the systemuser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Indicates if default outlook filters have been populated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
        public System.Nullable<bool> DefaultFiltersPopulated
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
            }
        }

        /// <summary>
        /// Select the mailbox associated with this user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox");
            }
        }

        /// <summary>
        /// Reason for disabling the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            get
            {
                return this.GetAttributeValue<string>("disabledreason");
            }
        }

        /// <summary>
        /// Whether to display the user in service views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
            }
            set
            {
                this.OnPropertyChanging("DisplayInServiceViews");
                this.SetAttributeValue("displayinserviceviews", value);
                this.OnPropertyChanged("DisplayInServiceViews");
                if ((this._changedAttributes.Contains("displayinserviceviews") == false))
                {
                    this._changedAttributes.Add("displayinserviceviews");
                }
            }
        }

        /// <summary>
        /// Active Directory domain of which the user is a member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
        public string DomainName
        {
            get
            {
                return this.GetAttributeValue<string>("domainname");
            }
            set
            {
                this.OnPropertyChanging("DomainName");
                this.SetAttributeValue("domainname", value);
                this.OnPropertyChanged("DomainName");
                if ((this._changedAttributes.Contains("domainname") == false))
                {
                    this._changedAttributes.Add("domainname");
                }
            }
        }

        /// <summary>
        /// Employee identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
        public string EmployeeId
        {
            get
            {
                return this.GetAttributeValue<string>("employeeid");
            }
            set
            {
                this.OnPropertyChanging("EmployeeId");
                this.SetAttributeValue("employeeid", value);
                this.OnPropertyChanged("EmployeeId");
                if ((this._changedAttributes.Contains("employeeid") == false))
                {
                    this._changedAttributes.Add("employeeid");
                }
            }
        }

        /// <summary>
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get
            {
                return this.GetAttributeValue<byte[]>("entityimage");
            }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
                if ((this._changedAttributes.Contains("entityimage") == false))
                {
                    this._changedAttributes.Add("entityimage");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get
            {
                return this.GetAttributeValue<string>("entityimage_url");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the systemuser with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            get
            {
                return this.GetAttributeValue<string>("firstname");
            }
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
                if ((this._changedAttributes.Contains("firstname") == false))
                {
                    this._changedAttributes.Add("firstname");
                }
            }
        }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            get
            {
                return this.GetAttributeValue<string>("fullname");
            }
        }

        /// <summary>
        /// Government identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
        public string GovernmentId
        {
            get
            {
                return this.GetAttributeValue<string>("governmentid");
            }
            set
            {
                this.OnPropertyChanging("GovernmentId");
                this.SetAttributeValue("governmentid", value);
                this.OnPropertyChanged("GovernmentId");
                if ((this._changedAttributes.Contains("governmentid") == false))
                {
                    this._changedAttributes.Add("governmentid");
                }
            }
        }

        /// <summary>
        /// Home phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
        public string HomePhone
        {
            get
            {
                return this.GetAttributeValue<string>("homephone");
            }
            set
            {
                this.OnPropertyChanging("HomePhone");
                this.SetAttributeValue("homephone", value);
                this.OnPropertyChanged("HomePhone");
                if ((this._changedAttributes.Contains("homephone") == false))
                {
                    this._changedAttributes.Add("homephone");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
                if ((this._changedAttributes.Contains("importsequencenumber") == false))
                {
                    this._changedAttributes.Add("importsequencenumber");
                }
            }
        }

        /// <summary>
        /// Internal email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
        public string InternalEMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("internalemailaddress");
            }
            set
            {
                this.OnPropertyChanging("InternalEMailAddress");
                this.SetAttributeValue("internalemailaddress", value);
                this.OnPropertyChanged("InternalEMailAddress");
                if ((this._changedAttributes.Contains("internalemailaddress") == false))
                {
                    this._changedAttributes.Add("internalemailaddress");
                }
            }
        }

        /// <summary>
        /// Information about whether the user is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
            }
        }

        /// <summary>
        /// Shows the status of approval of the email address by O365 Admin.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
        public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin");
            }
        }

        /// <summary>
        /// Check if user is an integration user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
        public System.Nullable<bool> IsIntegrationUser
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
            }
            set
            {
                this.OnPropertyChanging("IsIntegrationUser");
                this.SetAttributeValue("isintegrationuser", value);
                this.OnPropertyChanged("IsIntegrationUser");
                if ((this._changedAttributes.Contains("isintegrationuser") == false))
                {
                    this._changedAttributes.Add("isintegrationuser");
                }
            }
        }

        /// <summary>
        /// Information about whether the user is licensed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
        public System.Nullable<bool> IsLicensed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
            }
            set
            {
                this.OnPropertyChanging("IsLicensed");
                this.SetAttributeValue("islicensed", value);
                this.OnPropertyChanged("IsLicensed");
                if ((this._changedAttributes.Contains("islicensed") == false))
                {
                    this._changedAttributes.Add("islicensed");
                }
            }
        }

        /// <summary>
        /// Information about whether the user is synced with the directory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
        public System.Nullable<bool> IsSyncWithDirectory
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
            }
            set
            {
                this.OnPropertyChanging("IsSyncWithDirectory");
                this.SetAttributeValue("issyncwithdirectory", value);
                this.OnPropertyChanged("IsSyncWithDirectory");
                if ((this._changedAttributes.Contains("issyncwithdirectory") == false))
                {
                    this._changedAttributes.Add("issyncwithdirectory");
                }
            }
        }

        /// <summary>
        /// Job title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            get
            {
                return this.GetAttributeValue<string>("jobtitle");
            }
            set
            {
                this.OnPropertyChanging("JobTitle");
                this.SetAttributeValue("jobtitle", value);
                this.OnPropertyChanged("JobTitle");
                if ((this._changedAttributes.Contains("jobtitle") == false))
                {
                    this._changedAttributes.Add("jobtitle");
                }
            }
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            get
            {
                return this.GetAttributeValue<string>("lastname");
            }
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
                if ((this._changedAttributes.Contains("lastname") == false))
                {
                    this._changedAttributes.Add("lastname");
                }
            }
        }

        /// <summary>
        /// Middle name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            get
            {
                return this.GetAttributeValue<string>("middlename");
            }
            set
            {
                this.OnPropertyChanging("MiddleName");
                this.SetAttributeValue("middlename", value);
                this.OnPropertyChanged("MiddleName");
                if ((this._changedAttributes.Contains("middlename") == false))
                {
                    this._changedAttributes.Add("middlename");
                }
            }
        }

        /// <summary>
        /// Mobile alert email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
        public string MobileAlertEMail
        {
            get
            {
                return this.GetAttributeValue<string>("mobilealertemail");
            }
            set
            {
                this.OnPropertyChanging("MobileAlertEMail");
                this.SetAttributeValue("mobilealertemail", value);
                this.OnPropertyChanged("MobileAlertEMail");
                if ((this._changedAttributes.Contains("mobilealertemail") == false))
                {
                    this._changedAttributes.Add("mobilealertemail");
                }
            }
        }

        /// <summary>
        /// Mobile phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            get
            {
                return this.GetAttributeValue<string>("mobilephone");
            }
            set
            {
                this.OnPropertyChanging("MobilePhone");
                this.SetAttributeValue("mobilephone", value);
                this.OnPropertyChanged("MobilePhone");
                if ((this._changedAttributes.Contains("mobilephone") == false))
                {
                    this._changedAttributes.Add("mobilephone");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the user was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the systemuser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Nickname of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
        public string NickName
        {
            get
            {
                return this.GetAttributeValue<string>("nickname");
            }
            set
            {
                this.OnPropertyChanging("NickName");
                this.SetAttributeValue("nickname", value);
                this.OnPropertyChanged("NickName");
                if ((this._changedAttributes.Contains("nickname") == false))
                {
                    this._changedAttributes.Add("nickname");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
                if ((this._changedAttributes.Contains("overriddencreatedon") == false))
                {
                    this._changedAttributes.Add("overriddencreatedon");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the manager of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
            }
            set
            {
                this.OnPropertyChanging("ParentSystemUserId");
                this.SetAttributeValue("parentsystemuserid", value);
                this.OnPropertyChanged("ParentSystemUserId");
                if ((this._changedAttributes.Contains("parentsystemuserid") == false))
                {
                    this._changedAttributes.Add("parentsystemuserid");
                }
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
        public System.Nullable<int> PassportHi
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passporthi");
            }
            set
            {
                this.OnPropertyChanging("PassportHi");
                this.SetAttributeValue("passporthi", value);
                this.OnPropertyChanged("PassportHi");
                if ((this._changedAttributes.Contains("passporthi") == false))
                {
                    this._changedAttributes.Add("passporthi");
                }
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
        public System.Nullable<int> PassportLo
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passportlo");
            }
            set
            {
                this.OnPropertyChanging("PassportLo");
                this.SetAttributeValue("passportlo", value);
                this.OnPropertyChanged("PassportLo");
                if ((this._changedAttributes.Contains("passportlo") == false))
                {
                    this._changedAttributes.Add("passportlo");
                }
            }
        }

        /// <summary>
        /// Personal email address of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
        public string PersonalEMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("personalemailaddress");
            }
            set
            {
                this.OnPropertyChanging("PersonalEMailAddress");
                this.SetAttributeValue("personalemailaddress", value);
                this.OnPropertyChanged("PersonalEMailAddress");
                if ((this._changedAttributes.Contains("personalemailaddress") == false))
                {
                    this._changedAttributes.Add("personalemailaddress");
                }
            }
        }

        /// <summary>
        /// URL for the Website on which a photo of the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
        public string PhotoUrl
        {
            get
            {
                return this.GetAttributeValue<string>("photourl");
            }
            set
            {
                this.OnPropertyChanging("PhotoUrl");
                this.SetAttributeValue("photourl", value);
                this.OnPropertyChanged("PhotoUrl");
                if ((this._changedAttributes.Contains("photourl") == false))
                {
                    this._changedAttributes.Add("photourl");
                }
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
            }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
                if ((this._changedAttributes.Contains("processid") == false))
                {
                    this._changedAttributes.Add("processid");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the default queue for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Sdk.EntityReference QueueId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
            }
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                this.OnPropertyChanged("QueueId");
                if ((this._changedAttributes.Contains("queueid") == false))
                {
                    this._changedAttributes.Add("queueid");
                }
            }
        }

        /// <summary>
        /// Salutation for correspondence with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            get
            {
                return this.GetAttributeValue<string>("salutation");
            }
            set
            {
                this.OnPropertyChanging("Salutation");
                this.SetAttributeValue("salutation", value);
                this.OnPropertyChanged("Salutation");
                if ((this._changedAttributes.Contains("salutation") == false))
                {
                    this._changedAttributes.Add("salutation");
                }
            }
        }

        /// <summary>
        /// Check if user is a setup user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
        public System.Nullable<bool> SetupUser
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
            }
            set
            {
                this.OnPropertyChanging("SetupUser");
                this.SetAttributeValue("setupuser", value);
                this.OnPropertyChanged("SetupUser");
                if ((this._changedAttributes.Contains("setupuser") == false))
                {
                    this._changedAttributes.Add("setupuser");
                }
            }
        }

        /// <summary>
        /// Site at which the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
            }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
                if ((this._changedAttributes.Contains("siteid") == false))
                {
                    this._changedAttributes.Add("siteid");
                }
            }
        }

        /// <summary>
        /// Skill set of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
        public string Skills
        {
            get
            {
                return this.GetAttributeValue<string>("skills");
            }
            set
            {
                this.OnPropertyChanging("Skills");
                this.SetAttributeValue("skills", value);
                this.OnPropertyChanged("Skills");
                if ((this._changedAttributes.Contains("skills") == false))
                {
                    this._changedAttributes.Add("skills");
                }
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
            }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
                if ((this._changedAttributes.Contains("stageid") == false))
                {
                    this._changedAttributes.Add("stageid");
                }
            }
        }

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the territory to which the user is assigned.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public Microsoft.Xrm.Sdk.EntityReference TerritoryId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
            }
            set
            {
                this.OnPropertyChanging("TerritoryId");
                this.SetAttributeValue("territoryid", value);
                this.OnPropertyChanged("TerritoryId");
                if ((this._changedAttributes.Contains("territoryid") == false))
                {
                    this._changedAttributes.Add("territoryid");
                }
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
                if ((this._changedAttributes.Contains("timezoneruleversionnumber") == false))
                {
                    this._changedAttributes.Add("timezoneruleversionnumber");
                }
            }
        }

        /// <summary>
        /// Title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get
            {
                return this.GetAttributeValue<string>("title");
            }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
                if ((this._changedAttributes.Contains("title") == false))
                {
                    this._changedAttributes.Add("title");
                }
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the systemuser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
                if ((this._changedAttributes.Contains("transactioncurrencyid") == false))
                {
                    this._changedAttributes.Add("transactioncurrencyid");
                }
            }
        }

        /// <summary>
        /// Shows the type of user license.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userlicensetype")]
        public System.Nullable<int> UserLicenseType
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("userlicensetype");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
                if ((this._changedAttributes.Contains("utcconversiontimezonecode") == false))
                {
                    this._changedAttributes.Add("utcconversiontimezonecode");
                }
            }
        }

        /// <summary>
        /// Version number of the user.
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
        /// Windows Live ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
        public string WindowsLiveID
        {
            get
            {
                return this.GetAttributeValue<string>("windowsliveid");
            }
            set
            {
                this.OnPropertyChanging("WindowsLiveID");
                this.SetAttributeValue("windowsliveid", value);
                this.OnPropertyChanged("WindowsLiveID");
                if ((this._changedAttributes.Contains("windowsliveid") == false))
                {
                    this._changedAttributes.Add("windowsliveid");
                }
            }
        }

        /// <summary>
        /// User's Yammer login email address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
        public string YammerEmailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("yammeremailaddress");
            }
            set
            {
                this.OnPropertyChanging("YammerEmailAddress");
                this.SetAttributeValue("yammeremailaddress", value);
                this.OnPropertyChanged("YammerEmailAddress");
                if ((this._changedAttributes.Contains("yammeremailaddress") == false))
                {
                    this._changedAttributes.Add("yammeremailaddress");
                }
            }
        }

        /// <summary>
        /// User's Yammer ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
        public string YammerUserId
        {
            get
            {
                return this.GetAttributeValue<string>("yammeruserid");
            }
            set
            {
                this.OnPropertyChanging("YammerUserId");
                this.SetAttributeValue("yammeruserid", value);
                this.OnPropertyChanged("YammerUserId");
                if ((this._changedAttributes.Contains("yammeruserid") == false))
                {
                    this._changedAttributes.Add("yammeruserid");
                }
            }
        }

        /// <summary>
        /// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            get
            {
                return this.GetAttributeValue<string>("yomifirstname");
            }
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
                if ((this._changedAttributes.Contains("yomifirstname") == false))
                {
                    this._changedAttributes.Add("yomifirstname");
                }
            }
        }

        /// <summary>
        /// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            get
            {
                return this.GetAttributeValue<string>("yomifullname");
            }
        }

        /// <summary>
        /// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            get
            {
                return this.GetAttributeValue<string>("yomilastname");
            }
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
                if ((this._changedAttributes.Contains("yomilastname") == false))
                {
                    this._changedAttributes.Add("yomilastname");
                }
            }
        }

        /// <summary>
        /// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            get
            {
                return this.GetAttributeValue<string>("yomimiddlename");
            }
            set
            {
                this.OnPropertyChanging("YomiMiddleName");
                this.SetAttributeValue("yomimiddlename", value);
                this.OnPropertyChanged("YomiMiddleName");
                if ((this._changedAttributes.Contains("yomimiddlename") == false))
                {
                    this._changedAttributes.Add("yomimiddlename");
                }
            }
        }
  

        /// <summary>
        /// 1:N lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
                this.SetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
                this.SetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
                this.SetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
                this.SetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referenceduser_parent_user
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referenceduser_parent_user");
                this.SetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referenceduser_parent_user");
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinguser_parent_user
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.OnPropertyChanging("Referencinguser_parent_user");
                this.SetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinguser_parent_user");
                if ((this._changedAttributes.Contains("parentsystemuserid") == false))
                {
                    this._changedAttributes.Add("parentsystemuserid");
                }
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