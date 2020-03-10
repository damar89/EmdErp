using Ionic.Zip;
using NetSatis.EDonusum.FitServices;
using NetSatis.EDonusum.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using UBLObject;

namespace NetSatis.EDonusum.Controller
{
    public class FaturaGonderController
    {
        StringWriter SW1;
        FileStream FS;
        IssueDateType issueDate;
        IssueTimeType issueTime;
        int intNStokId;
        String GuidId;
        String CUST_NEW_ID;
        public class RestSonuc
        {
            public int Sonuc { get; set; }
            public string Aciklama { get; set; }
            public string FirmaNo { get; set; }
            public string Vkn { get; set; }
        }

        public void FaturaEarsiveGondermeIslemi(List<Donusum.Master> m)
        {
            foreach (var d in m)
            {
                DateTime dt = DateTime.Now;
                #region Fields
                //burası
                string StokFisiId = Convert.ToString(d.Id);
                string AlisverisId = "";
                int GonderilmeyenFaturalar = 0;
                string _ProfileId = "";
                string _ID = "";
                string _VKNSONUC = "";
                string FisNo = "";
                string _IssueDateYear = dt.Year.ToString();
                string _IssueDateMonth = dt.Month.ToString();
                string _IssueDateDay = dt.Day.ToString();
                string _IssueDateHour = dt.Hour.ToString();
                string _IssueDateMinute = dt.Minute.ToString();
                string _IssueDateSecond = dt.Second.ToString();
                string _IssueTime = dt.TimeOfDay.ToString();
                string _InvoiceTypeCode = "";
                string _Note = "";
                string _DocumentCurrencyCode = "TRY";
                string _LineCountNumeric = "";
                string _ASP_VKN = "";
                string _ASP_WebAdres = "";
                string _ASP_TICARETSICILNO = "";
                string _ASP_MERSISNO = "";
                string _ASP_NAME = "";
                string _ASP_StreetName = "";
                string _ASP_CitySubdivisionName = "";
                string _ASP_CityName = "";
                string _ASP_PostalZone = "";
                string _ASP_CountryName = "";
                string _ASP_BuildingName = "";
                string _ASP_BuildingNumber = "";
                string _ASP_PartyTaxScheme = "";
                string _ASP_Tel = "";
                string _ASP_Fax = "";
                string _ASP_Email = "";
                string _ACP_VKN = "";
                string _ACP_TCKN = "";
                string _ACP_TICARETSICILNO = "";
                string _ACP_MERSISNO = "";
                string _ACP_NAME = "";
                string _ACP_StreetName = "";
                string _ACP_CitySubdivisionName = "";
                string _ACP_CityName = "";
                string _ACP_PostalZone = "";
                string _ACP_CountryName = "";
                string _ACP_PartyTaxScheme = "";
                string _ACP_Tel = "";
                string _ACP_Fax = "";
                string _ACP_Email = "";
                string _ACP_Adi = "";
                string _ACP_Soyadi = "";
                string _TT_TaxAmount = "";
                string _TT_TaxableAmount = "";
                string _TT_Percent = "";
                string _LMT_LineExtensionAmount = "";
                string _LMT_TaxExclusiveAmount = "";
                string _LMT_TaxInclusiveAmount = "";
                string _LMT_AllowanceTotalAmount = "";
                string _LMT_PayableAmount = "";
                string KdvIstisnasi = "";
                string KdvIstisnasiCode = "";
                String strFatura = "";

                #endregion

                #region AdditionalDocumentReference

                Type aa = Type.GetType("System.Xml.XmlElement");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<xml />");
                issueDate = new IssueDateType
                {
                    Value = new DateTime(Convert.ToInt32(_IssueDateYear), Convert.ToInt32(_IssueDateMonth),
                        Convert.ToInt32(_IssueDateDay), Convert.ToInt32(_IssueDateHour),
                        Convert.ToInt32(_IssueDateMinute), Convert.ToInt32(_IssueDateSecond))
                };
                issueTime = new IssueTimeType {Value = Convert.ToDateTime(_IssueTime)};

                InvoiceType earsiv = new InvoiceType()
                {
                    UBLExtensions = new UBLExtensionType[]
                    {
                        new UBLExtensionType()
                        {
                            ExtensionContent = doc.DocumentElement
                        }
                    },

                    UBLVersionID = new UBLVersionIDType {Value = "2.1"},
                    CustomizationID = new CustomizationIDType {Value = "TR1.2"},
                    ProfileID = new ProfileIDType {Value = _ProfileId},
                    ID = new IDType {Value = _ID},
                    CopyIndicator = new CopyIndicatorType {Value = false},
                    UUID = new UUIDType {Value = GuidId},
                    IssueDate = issueDate,
                    IssueTime = issueTime,
                    InvoiceTypeCode = new InvoiceTypeCodeType {Value = _InvoiceTypeCode},
                    DocumentCurrencyCode = new DocumentCurrencyCodeType {Value = "TRY"},
                    LineCountNumeric = new LineCountNumericType {Value = Convert.ToInt32(_LineCountNumeric)},
                    //Note = new NoteType[] { new NoteType() { Value = _Note } },
                    //  Note = new NoteType { Value = _Note }

                    #endregion

                    #region //Signature

                    Signature = new SignatureType[]
                    {
                        new SignatureType
                        {
                            ID = new IDType {schemeID = "VKN_TCKN", Value = _ASP_VKN},
                            SignatoryParty = new PartyType
                            {
                                PartyIdentification = new PartyIdentificationType[]
                                {
                                    new PartyIdentificationType()
                                    {
                                        ID = new IDType {schemeID = "VKN", Value = _ASP_VKN}
                                    }
                                },

                                PostalAddress = new AddressType
                                {
                                    StreetName = new StreetNameType {Value = _ASP_StreetName},
                                    BuildingName = new BuildingNameType {Value = _ASP_BuildingName},
                                    CitySubdivisionName =
                                        new CitySubdivisionNameType {Value = _ASP_CitySubdivisionName},
                                    CityName = new CityNameType {Value = _ASP_CityName},
                                    PostalZone = new PostalZoneType {Value = _ASP_PostalZone},
                                    Country = new CountryType {Name = new NameType1 {Value = _ASP_CountryName}}
                                }
                            },

                            DigitalSignatureAttachment = new AttachmentType
                            {
                                ExternalReference = new ExternalReferenceType
                                {
                                    URI = new URIType {Value = "#Signature"}
                                }
                            }
                        },
                    },

                    #endregion

                    #region //AccountingSupplierParty

                    AccountingSupplierParty = new SupplierPartyType //gönderenin fatura üzerindeki bilgileri
                    {
                        Party = new PartyType()
                        {
                            WebsiteURI = new WebsiteURIType {Value = _ASP_WebAdres},

                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType()
                                {

                                    ID = new IDType {schemeID = "VKN", Value = _ASP_VKN}
                                }

                                //new PartyIdentificationType() {

                                //   ID = new IDType { schemeID = "TICARETSICILNO", Value = _ASP_TICARETSICILNO }},
                                // new PartyIdentificationType() {

                                //   ID = new IDType { schemeID = "MERSISNO", Value = _ASP_MERSISNO }}

                            },


                            PartyName = new PartyNameType {Name = new NameType1 {Value = _ASP_NAME}},

                            PostalAddress = new AddressType
                            {
                                ID = new IDType {Value = "1234567890"},
                                BuildingNumber = new BuildingNumberType {Value = _ASP_BuildingNumber},
                                StreetName = new StreetNameType {Value = _ASP_StreetName},
                                BuildingName = new BuildingNameType {Value = _ASP_BuildingName},
                                CitySubdivisionName = new CitySubdivisionNameType {Value = _ASP_CitySubdivisionName},
                                CityName = new CityNameType {Value = _ASP_CityName},
                                PostalZone = new PostalZoneType {Value = _ASP_PostalZone},
                                Country = new CountryType {Name = new NameType1 {Value = _ASP_CountryName}}
                            },

                            PartyTaxScheme = new PartyTaxSchemeType
                            {
                                TaxScheme = new TaxSchemeType {Name = new NameType1 {Value = _ASP_PartyTaxScheme}}
                            },

                            Contact = new ContactType
                            {
                                Telephone = new TelephoneType {Value = _ASP_Tel},
                                Telefax = new TelefaxType {Value = _ASP_Fax},
                                ElectronicMail = new ElectronicMailType {Value = _ASP_Email}
                            }
                        }
                    },

                    #endregion

                    #region //AccountingCustomerParty

                    AccountingCustomerParty = new CustomerPartyType //Alıcının fatura üzerindeki bilgileri
                    {
                        Party = new PartyType
                        {
                            WebsiteURI = new WebsiteURIType {Value = ""},
                            PartyName = new PartyNameType {Name = new NameType1 {Value = _ACP_NAME}}, //ünvan

                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType()
                                {

                                    ID = new IDType {schemeID = _VKNSONUC, Value = _ACP_VKN,}
                                },
                                new PartyIdentificationType()
                                {
                                    ID = new IDType {schemeID = "TESISATNO", Value = _ACP_TCKN}
                                },

                                new PartyIdentificationType()
                                {
                                    ID = new IDType {schemeID = "SAYACNO", Value = _ACP_TCKN}
                                }

                            },

                            PostalAddress = new AddressType
                            {
                                ID = new IDType {Value = "ADRES"},
                                StreetName = new StreetNameType {Value = _ACP_StreetName},
                                BuildingName = new BuildingNameType {Value = ""},
                                BuildingNumber = new BuildingNumberType {Value = ""},
                                CitySubdivisionName = new CitySubdivisionNameType {Value = _ACP_CitySubdivisionName},
                                CityName = new CityNameType {Value = _ACP_CityName},
                                PostalZone = new PostalZoneType {Value = _ACP_PostalZone},

                                Country = new CountryType {Name = new NameType1 {Value = _ACP_CountryName}}
                            },

                            Contact = new ContactType
                            {
                                Telephone = new TelephoneType {Value = _ACP_Tel},
                                Telefax = new TelefaxType {Value = _ACP_Fax},
                                ElectronicMail = new ElectronicMailType {Value = _ACP_Email}
                            },

                            Person = new PersonType
                            {
                                FirstName = new FirstNameType {Value = _ACP_Adi},
                                FamilyName = new FamilyNameType {Value = _ACP_Soyadi}

                            }

                        }
                    },

                    #endregion

                    #region //PaymentTerms

                    //PaymentTerms = new PaymentTermsType
                    //{
                    //    Note = new NoteType { Value = _Note }                            

                    //},


                    #endregion

                    #region //LegalMonetaryTotal

                    LegalMonetaryTotal = new MonetaryTotalType
                    {
                        LineExtensionAmount = new LineExtensionAmountType
                            {currencyID = "TRY", Value = Convert.ToDecimal(_LMT_LineExtensionAmount)},
                        TaxExclusiveAmount = new TaxExclusiveAmountType
                            {currencyID = "TRY", Value = Convert.ToDecimal(_LMT_TaxExclusiveAmount)},
                        TaxInclusiveAmount = new TaxInclusiveAmountType
                            {currencyID = "TRY", Value = Convert.ToDecimal(_LMT_TaxInclusiveAmount)},
                        PayableAmount = new PayableAmountType
                            {currencyID = "TRY", Value = Convert.ToDecimal(_LMT_PayableAmount)}
                    },

                    #endregion

                    InvoiceLine = InvoiceLineDoldur(d.Id),
                    TaxTotal = Taxlar(_TT_TaxAmount)
                };
                earsiv.Note = NoteDoldur();
                InvoiceType createdUbl = CreateUBL(earsiv);
                strFatura = GetInvoiceXML(createdUbl, _ID);

                strFatura = strFatura.Replace("<xml xmlns=\"\" />", "");
                string Hata = "";
                if (KdvIstisnasiCode == "")
                {
                    strFatura = strFatura.Replace(" <cbc:TaxExemptionReasonCode />", "")
                        .Replace(" <cbc:TaxExemptionReason />", "");
                }

                String userName = "2hgiL6Mu";
                String passWord = "9k_EHVon";

                var gon = FaturaGonder(_ASP_VKN, userName, passWord, strFatura, GuidId);
                if (gon != null)
                {
                    string sonuc = gon.Result.Result1.ToString();
                }
            }
        }
        private InvoiceType CreateUBL(InvoiceType _Fatura)
        {
            InvoiceType Fatura = _Fatura;
            return Fatura;
        }
        private NoteType[] NoteDoldur()
        {
            List<NoteType> Liste = new List<NoteType>();
            string _Note = "";
            string _Ozellik1 = "";
            string _DovizKuru = "";
            string _Note_1 = "";
            string _Note_2 = "";
            string _Note_3 = "";
            string _Note_4 = "";
            string _Note_5 = "";
            string _Note_6 = "";
            string _Note_7 = "";
            string _Note_8 = "";
            string _Note_9 = "";
            string _Note_10 = "";
            _Note = Convert.ToString(_Note);
            //_Ozellik1 = Convert.ToString(drv1["IN_OzelAlan1"]);
            //_DovizKuru = "Döviz Kuru : " + Convert.ToString(drv1["IN_DovizKuru"]);
            _Note_1 = Convert.ToString(_Note_1);
            _Note_2 = Convert.ToString(_Note_2);
            _Note_3 = Convert.ToString(_Note_3);
            _Note_4 = Convert.ToString(_Note_4);
            _Note_5 = Convert.ToString(_Note_5);
            _Note_6 = Convert.ToString(_Note_6);
            _Note_7 = Convert.ToString(_Note_7);
            _Note_8 = Convert.ToString(_Note_8);
            _Note_9 = Convert.ToString(_Note_9);
            _Note_10 = Convert.ToString(_Note_10);
            //NoteType DovizKuru = new NoteType()
            //{
            //    Value = _DovizKuru
            //};
            //Liste.Add(DovizKuru);
            NoteType note = new NoteType()
            {
                Value = _Note
            };
            Liste.Add(note);
            //NoteType Ozellik1 = new NoteType()
            //{
            //    Value = _Ozellik1
            //};
            //Liste.Add(Ozellik1);
            NoteType Note1 = new NoteType()
            {
                Value = _Note_1
            };
            Liste.Add(Note1);
            NoteType Note2 = new NoteType()
            {
                Value = _Note_2
            };
            Liste.Add(Note2);
            NoteType Note3 = new NoteType()
            {
                Value = _Note_3
            };
            Liste.Add(Note3);
            NoteType Note4 = new NoteType()
            {
                Value = _Note_4
            };
            Liste.Add(Note4);
            NoteType Note5 = new NoteType()
            {
                Value = _Note_5
            };
            Liste.Add(Note5);
            NoteType Note6 = new NoteType()
            {
                Value = _Note_6
            };
            Liste.Add(Note6);
            NoteType Note7 = new NoteType()
            {
                Value = _Note_7
            };
            Liste.Add(Note7);
            NoteType Note8 = new NoteType()
            {
                Value = _Note_8
            };
            Liste.Add(Note8);
            NoteType Note9 = new NoteType()
            {
                Value = _Note_9
            };
            Liste.Add(Note9);
            NoteType Note10 = new NoteType()
            {
                Value = _Note_10
            };
            Liste.Add(Note10);
            return Liste.ToArray();
        }
        private DocumentReferenceType[] XsltEkle()
        {
            string Dosya = "";
            byte[] fileByteArray4;
            if (intNStokId > 0)
            {
                //Dosya = Convert.ToString(SqlProcess.SelectIslemiYap("Select @p1=XsltYolu From Xslt Where Type=2", DBNAME));
                fileByteArray4 = File.ReadAllBytes(Dosya);
            }

            else
            {
                //Dosya = Convert.ToString(SqlProcess.SelectIslemiYap("Select @p1=XsltYolu From Xslt Where Type=3", DBNAME));
                fileByteArray4 = File.ReadAllBytes(Dosya);
            }

            DocumentReferenceType[] Drt;

            Drt = new DocumentReferenceType[]
               {
                    new DocumentReferenceType()
                        {
                            ID = new IDType { Value = "0100" },
                            IssueDate = issueDate,
                            DocumentTypeCode = new DocumentTypeCodeType { Value = "OUTPUT_TYPE" }
                        },


                    new DocumentReferenceType() //efatura dan farklı olarak sadece bu alan eklenmiştir. 
                        {
                            ID = new IDType { Value = "ELEKTRONIK" },
                            IssueDate = issueDate,
                            DocumentTypeCode = new DocumentTypeCodeType { Value = "EREPSENDT" }
                        },

                    new DocumentReferenceType()
                        {
                            ID = new IDType { Value = "99" },
                            IssueDate = issueDate,
                            DocumentTypeCode = new DocumentTypeCodeType { Value = "TRANSPORT_TYPE" }
                        },

                    new DocumentReferenceType()
                        {
                          ID = new IDType { Value = GuidId },

                        IssueDate = issueDate,
                        DocumentTypeCode = new DocumentTypeCodeType { Value = "XSLT" },
                        DocumentType = new DocumentTypeType { Value = "XSLT" },

                         Attachment = new AttachmentType
                         {
                         EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType
                             {
                                characterSetCode = "UTF-8",
                                encodingCode = "Base64",
                                mimeCode = "application/xml",
                                filename = Dosya.Replace("C:\\ProgramData\\", ""),
                                Value = fileByteArray4
                             }
                        }
                }
             };



            return Drt;
        }
        private string GetAuthorization(string username, string pass)
        {
            string authorization = username + ":" + pass; //kullanıcı adı ve şifre. aralarında : karakteri olacak.
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(authorization);
            string base64authorization = Convert.ToBase64String(byteArray);

            return string.Format("Basic {0}", base64authorization);
        }
        private byte[] IonicZipFile(string xml, string fileName)
        {

            byte[] ziplenecekData = Encoding.UTF8.GetBytes(xml);

            MemoryStream zipStream = new MemoryStream();

            using (ZipFile zip = new Ionic.Zip.ZipFile())
            {
                ZipEntry zipEleman = zip.AddEntry(fileName + ".xml", ziplenecekData);

                zip.Save(zipStream);
            }

            zipStream.Seek(0, SeekOrigin.Begin);
            zipStream.Flush();

            zipStream.Position = 0;
            return zipStream.ToArray();
        }
        private string GetHashInfo(byte[] file)
        {
            using (var md5 = MD5.Create())
            {
                byte[] aa = md5.ComputeHash(file);

                var hash = BitConverter.ToString(aa).Replace("-", "").ToLower();

                return hash;
            }
        }
        private TaxTotalType[] Taxlar(string _GenelToplamTax)
        {
            List<TaxTotalType> Liste = new List<TaxTotalType>();
            string GenelToplamTax = _GenelToplamTax;
            TaxTotalType _taxTotalType = new TaxTotalType()
            {
                TaxAmount = new TaxAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_GenelToplamTax) }
            };
            _taxTotalType.TaxSubtotal = SubTotalEkle();

            Liste.Add(_taxTotalType);

            return Liste.ToArray();
        }
        private TaxSubtotalType[] SubTotalEkle()
        {
            List<TaxSubtotalType> Liste = new List<TaxSubtotalType>();
            string _TT_TaxableAmount = "";
            string _TT_TaxAmount = "";
            string _TT_TaxPercent = "";
            string _TT_TaxableAmount_1 = "";
            string _TT_TaxAmount_1 = "";
            string _TT_TaxPercent_1 = "";
            string _TT_TaxableAmount_2 = "";
            string _TT_TaxAmount_2 = "";
            string _TT_TaxPercent_2 = "";
            string _TT_TaxableAmount_3 = "";
            string _TT_TaxAmount_3 = "";
            string _TT_TaxPercent_3 = "";
            string _TT_TaxableAmount_4 = "";
            string _TT_TaxAmount_4 = "";
            string _TT_TaxPercent_4 = "";
            string _TT_TaxableAmount_5 = "";
            string _TT_TaxAmount_5 = "";
            string _TT_TaxPercent_5 = "";
            _TT_TaxableAmount = Convert.ToString(_TT_TaxableAmount);
            _TT_TaxAmount = Convert.ToString(_TT_TaxAmount);
            _TT_TaxPercent = Convert.ToString(_TT_TaxPercent);
            _TT_TaxableAmount_1 = Convert.ToString(_TT_TaxableAmount_1);
            _TT_TaxAmount_1 = Convert.ToString(_TT_TaxAmount_1);
            _TT_TaxPercent_1 = Convert.ToString(_TT_TaxPercent_1);
            _TT_TaxableAmount_2 = Convert.ToString(_TT_TaxableAmount_2);
            _TT_TaxAmount_2 = Convert.ToString(_TT_TaxAmount_2);
            _TT_TaxPercent_2 = Convert.ToString(_TT_TaxPercent_2);
            _TT_TaxableAmount_3 = Convert.ToString(_TT_TaxableAmount_3);
            _TT_TaxAmount_3 = Convert.ToString(_TT_TaxAmount_3);
            _TT_TaxPercent_3 = Convert.ToString(_TT_TaxPercent_3);
            _TT_TaxableAmount_4 = Convert.ToString(_TT_TaxableAmount_4);
            _TT_TaxAmount_4 = Convert.ToString(_TT_TaxAmount_4);
            _TT_TaxPercent_4 = Convert.ToString(_TT_TaxPercent_4);
            _TT_TaxableAmount_5 = Convert.ToString(_TT_TaxableAmount_5);
            _TT_TaxAmount_5 = Convert.ToString(_TT_TaxAmount_5);
            _TT_TaxPercent_5 = Convert.ToString(_TT_TaxPercent_5);

            if (_TT_TaxAmount_1 != "0,00")
            {
                if (_TT_TaxAmount_1 != "0.00")
                {
                    TaxSubtotalType TaxSubtotal = new TaxSubtotalType()
                    {
                        TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxableAmount_1) },

                        TaxAmount = new TaxAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxAmount_1) },
                        CalculationSequenceNumeric = new CalculationSequenceNumericType { Value = 1 },
                        Percent = new PercentType1 { Value = Convert.ToDecimal(_TT_TaxPercent_1) },
                        TaxCategory = new TaxCategoryType
                        {
                            TaxScheme = new TaxSchemeType { TaxTypeCode = new TaxTypeCodeType { Value = "0015" } }
                        }
                    };
                    Liste.Add(TaxSubtotal);
                }

            }
            if (_TT_TaxAmount_2 != "0,00")
            {
                if (_TT_TaxAmount_2 != "0.00")
                {
                    TaxSubtotalType TaxSubtotal = new TaxSubtotalType()
                    {
                        TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxableAmount_2) },

                        TaxAmount = new TaxAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxAmount_2) },
                        CalculationSequenceNumeric = new CalculationSequenceNumericType { Value = 2 },
                        Percent = new PercentType1 { Value = Convert.ToDecimal(_TT_TaxPercent_2) },
                        TaxCategory = new TaxCategoryType
                        {
                            TaxScheme = new TaxSchemeType { TaxTypeCode = new TaxTypeCodeType { Value = "0015" } }
                        }
                    };
                    Liste.Add(TaxSubtotal);

                }

            }
            if (_TT_TaxAmount_3 != "0,00")
            {
                if (_TT_TaxAmount_3 != "0.00")
                {
                    TaxSubtotalType TaxSubtotal = new TaxSubtotalType()
                    {
                        TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxableAmount_3) },

                        TaxAmount = new TaxAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxAmount_3) },
                        CalculationSequenceNumeric = new CalculationSequenceNumericType { Value = 3 },
                        Percent = new PercentType1 { Value = Convert.ToDecimal(_TT_TaxPercent_3) },
                        TaxCategory = new TaxCategoryType
                        {
                            TaxScheme = new TaxSchemeType { TaxTypeCode = new TaxTypeCodeType { Value = "0015" } }
                        }
                    };
                    Liste.Add(TaxSubtotal);
                }

            }
            if (_TT_TaxAmount_4 != "0,00")
            {
                if (_TT_TaxAmount_4 != "0.00")
                {
                    TaxSubtotalType TaxSubtotal = new TaxSubtotalType()
                    {
                        TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxableAmount_4) },

                        TaxAmount = new TaxAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxAmount_4) },
                        CalculationSequenceNumeric = new CalculationSequenceNumericType { Value = 4 },
                        Percent = new PercentType1 { Value = Convert.ToDecimal(_TT_TaxPercent_4) },
                        TaxCategory = new TaxCategoryType
                        {
                            TaxScheme = new TaxSchemeType { TaxTypeCode = new TaxTypeCodeType { Value = "0015" } }
                        }
                    };
                    Liste.Add(TaxSubtotal);
                }

            }
            if (_TT_TaxAmount_5 != "0,00")
            {
                if (_TT_TaxAmount_5 != "0.00")
                {
                    TaxSubtotalType TaxSubtotal = new TaxSubtotalType()
                    {
                        TaxableAmount = new TaxableAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxableAmount_5) },

                        TaxAmount = new TaxAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_TT_TaxAmount_5) },
                        CalculationSequenceNumeric = new CalculationSequenceNumericType { Value = 5 },
                        Percent = new PercentType1 { Value = Convert.ToDecimal(_TT_TaxPercent_5) },
                        TaxCategory = new TaxCategoryType
                        {
                            TaxScheme = new TaxSchemeType { TaxTypeCode = new TaxTypeCodeType { Value = "0015" } }
                        }
                    };
                    Liste.Add(TaxSubtotal);
                }

            }
            return Liste.ToArray();
        }
        public class Stoklar
        {
            public int Id { get; set; }
            public string StokKodu { get; set; }
            public string StokAdi { get; set; }
        }
        private InvoiceLineType[] InvoiceLineDoldur(int Master)
        {
            List<InvoiceLineType> Liste = new List<InvoiceLineType>();
            using (VTContext db = new VTContext())
            {
                var list = db.Detail.Where(x => x.MasterId == Master).ToList();
                foreach (var item in list)
                {
                    var veri = db.Database.SqlQuery<Stoklar>("SELECT Id,StokKodu,StokAdi FROM Stoklar where Id='" +
                                                             item.StokId + "'").FirstOrDefault();
                    string _IL_ID = Convert.ToString(item.StokId);
                    string _IL_StokCode = Convert.ToString(veri.StokKodu);
                    string _IL_InvoicedQuantity = Convert.ToString(item.Miktar);
                    string _IL_LineExtensionAmount = "0";
                    string _IL_TaxAmount = Convert.ToString(item.KdvOrani);
                    string _IL_TaxableAmount = Convert.ToString(item.Kdv);
                    string _IL_Percent = "";
                    string _IL_TaxCategory_Name = "";
                    string _IL_TaxCategory_TaxTypeCode = "";
                    string _IL_ItemName = veri.StokAdi;
                    string _IL_Price = Convert.ToString(item.Tutar);
                    string _IL_Birim = "C62";
                    string KdvIstisnasi = "";
                    string KdvIstisnasiCode = "";
                    _IL_ID = Convert.ToString(_IL_ID);
                    _IL_StokCode = Convert.ToString(_IL_StokCode);
                    _IL_InvoicedQuantity = Convert.ToString(_IL_InvoicedQuantity);
                    _IL_LineExtensionAmount = Convert.ToString(_IL_LineExtensionAmount);
                    _IL_TaxAmount = Convert.ToString(_IL_TaxAmount);
                    _IL_TaxableAmount = Convert.ToString(_IL_TaxableAmount);
                    _IL_Percent = Convert.ToString(_IL_Percent);
                    _IL_TaxCategory_Name = Convert.ToString(_IL_TaxCategory_Name);
                    _IL_TaxCategory_TaxTypeCode = Convert.ToString(_IL_TaxCategory_TaxTypeCode);
                    _IL_ItemName = Convert.ToString(_IL_ItemName);
                    _IL_Price = Convert.ToString(_IL_Price);
                    _IL_Birim = Convert.ToString(_IL_Birim);
                    KdvIstisnasi = Convert.ToString(KdvIstisnasi);
                    KdvIstisnasiCode = Convert.ToString(KdvIstisnasiCode);


                    InvoiceLineType lineItem = new InvoiceLineType()
                    {
                        ID = new IDType {Value = _IL_ID},
                        InvoicedQuantity = new InvoicedQuantityType
                            {unitCode = _IL_Birim, Value = Math.Round(Convert.ToDecimal(_IL_InvoicedQuantity), 4)},
                        LineExtensionAmount = new LineExtensionAmountType
                            {currencyID = "TRY", Value = Math.Round(Convert.ToDecimal(_IL_LineExtensionAmount), 4)},

                        AllowanceCharge = new AllowanceChargeType[]
                        {
                            new AllowanceChargeType()
                            {
                                ChargeIndicator = new ChargeIndicatorType {Value = false},
                                MultiplierFactorNumeric = new MultiplierFactorNumericType {Value = 0.00M},
                                Amount = new AmountType2 {currencyID = "TRY", Value = 0.00M},
                                BaseAmount = new BaseAmountType
                                    {currencyID = "TRY", Value = Math.Round(Convert.ToDecimal(_IL_TaxableAmount), 4)}
                            }
                        },

                        TaxTotal = new TaxTotalType
                        {
                            TaxAmount = new TaxAmountType
                                {currencyID = "TRY", Value = Math.Round(Convert.ToDecimal(_IL_TaxAmount), 4)},

                            TaxSubtotal = new TaxSubtotalType[]
                            {
                                new TaxSubtotalType()
                                {
                                    TaxableAmount = new TaxableAmountType
                                    {
                                        currencyID = "TRY", Value = Math.Round(Convert.ToDecimal(_IL_TaxableAmount), 4)
                                    },
                                    TaxAmount = new TaxAmountType
                                        {currencyID = "TRY", Value = Math.Round(Convert.ToDecimal(_IL_TaxAmount), 4)},
                                    Percent = new PercentType1 {Value = Math.Round(Convert.ToDecimal(_IL_Percent), 4)},

                                    TaxCategory = new TaxCategoryType
                                    {
                                        TaxScheme = new TaxSchemeType
                                        {
                                            Name = new NameType1 {Value = "KDV"},
                                            TaxTypeCode = new TaxTypeCodeType {Value = "0015"}
                                        },
                                        TaxExemptionReasonCode = new TaxExemptionReasonCodeType
                                            {Value = KdvIstisnasiCode},
                                        TaxExemptionReason = new TaxExemptionReasonType {Value = KdvIstisnasi}
                                    }
                                }
                            },
                        },

                        Item = new ItemType
                        {
                            Name = new NameType1 {Value = _IL_ItemName},
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = new IDType {Value = _IL_StokCode.Replace(" ", "")}
                            }

                        },
                        Price = new PriceType
                        {
                            PriceAmount = new PriceAmountType
                                {currencyID = "TRY", Value = Math.Round(Convert.ToDecimal(_IL_Price), 4)}
                        }
                    };

                    Liste.Add(lineItem);
                }
            }

            return Liste.ToArray();
        }
        public static string GetInvoiceXML<T>(T obj, string DosyaAdi)
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(T));
            string Belgelerim = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
            ns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            ns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            ns.Add("ccts", "urn:un:unece:uncefact:documentation:2");
            ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
            ns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            ns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            ns.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
            ns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            ns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            ns.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            MemoryStream ms = new MemoryStream();

            Encoding utf8EncodingWithoutBom = new UTF8Encoding(false);

            TextWriter WriteFileStream = new StreamWriter(ms, utf8EncodingWithoutBom);

            SerializerObj.Serialize(WriteFileStream, obj, ns);


            WriteFileStream.Close();
            return utf8EncodingWithoutBom.GetString(ms.ToArray());



        }
        static string GetXmlString(string strFile)
        {
            // Load the xml file into XmlDocument object.
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(strFile);
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
            }
            // Now create StringWriter object to get data from xml document.
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);
            xmlDoc.WriteTo(xw);
            return sw.ToString();
        }
        public sendInvoiceResponseType FaturaGonder(string TCKN_VKN, string wsUserName, string wsPass, string Fatura, String UUID)
        {

            byte[] byteFatura = System.Text.Encoding.ASCII.GetBytes(Fatura); //xml verisini byte tipine çeviriyoruz.


            byte[] zipliFile = IonicZipFile(Fatura, UUID); //xml olarak dönüştürülen e-arşiv faturasını zip dosyası içine ekliyoruz.


            string hash = GetHashInfo(zipliFile); //ziplenen e-arşiv faturasının hash bilgisini alıyoruz.


            eArsivInvoicePortTypeClient wsClient = new eArsivInvoicePortTypeClient();

            using (new System.ServiceModel.OperationContextScope((System.ServiceModel.IClientChannel)wsClient.InnerChannel))
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.Headers.Add(HttpRequestHeader.Authorization, GetAuthorization(wsUserName, wsPass));


                var req = new sendInvoiceRequest() //fatura göndermek için request parametrelerini set ediyoruz.
                {
                    sendInvoiceRequestType = new SendInvoiceRequestType
                    {
                        senderID = TCKN_VKN,
                        receiverID = "1111111111",
                        fileName = UUID,
                        binaryData = zipliFile,
                        docType = "XML",
                        hash = hash,

                        responsiveOutput = new ResponsiveOutput //gönerilen faturanın dönen cevabında binary olarak fatura görüntüsü almak için. opsiyonel alan.
                        {
                            outputType = ResponsiveOutputType.PDF,
                            outputTypeSpecified = true
                        }

                    }
                };

                var result = wsClient.sendInvoice(req.sendInvoiceRequestType);

                return result;

            }


        }
    }
}
