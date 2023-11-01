import { proxyTexts } from "@serenity-is/corelib/q";

namespace MasterDirectory.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RolePermissionId: string;
                export const RoleRoleName: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Catalogos {

            namespace TipoCatalogos {
                export const Activo: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const IdtipoCategoria: string;
                export const NombreTipoCategoria: string;
                export const TipoCatalogo: string;
            }

            namespace TipoCategorias {
                export const Activo: string;
                export const IdtipoCategoria: string;
                export const TipoCategoria: string;
            }
        }

        namespace Comerciales {

            namespace CatalogosComerciales {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaComerciales {
                export const Cajonera: string;
                export const ExhibMostrador: string;
                export const Hp1: string;
                export const Hp2: string;
                export const Hp3: string;
                export const Islas: string;
                export const Kioscos: string;
                export const LocalSap: string;
                export const M2Local: string;
                export const M2Pdv: string;
                export const MedidaCabecera: string;
                export const MuebleGenericos: string;
                export const No7: string;
                export const Refri4puertas: string;
                export const RefriMostradorFarma: string;
                export const SoapYGlory: string;
                export const Tabaquera: string;
                export const TabletasFujiFilm: string;
                export const TempoFarma: string;
                export const TirasImpulso: string;
                export const TotEspacioExhibFarm: string;
                export const TramosCajonera: string;
                export const TramosDermo: string;
            }
        }

        namespace Consultorios {

            namespace CatalogosConsultorios {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaConsultorios {
                export const Benamedic: string;
                export const ConsulOperacion: string;
                export const HorarioD: string;
                export const HorarioLv: string;
                export const HorarioS: string;
                export const LocalSap: string;
            }
        }

        namespace Digital {

            namespace CatalogosDigital {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaDigital {
                export const DirGoogle: string;
                export const Latitud: string;
                export const LinkGoogleMaps: string;
                export const LocalSap: string;
                export const Longitud: string;
            }
        }

        namespace Expansion {

            namespace CatalogosExpansion {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaExpansion {
                export const Ciudad: string;
                export const Colonia: string;
                export const ColorMob: string;
                export const Comsuc: string;
                export const Cp: string;
                export const Dermo: string;
                export const Direccion: string;
                export const Estado: string;
                export const Farmacia: string;
                export const FechaApertura: string;
                export const FormatoFarmAlcance: string;
                export const Latitud: string;
                export const LocalSap: string;
                export const LocationType: string;
                export const Longuitud: string;
                export const NCajonesEstaciona: string;
                export const NExterior: string;
                export const Pantallas: string;
                export const ProvMobiliario: string;
                export const Reapertura: string;
                export const TipoEstaciona: string;
            }
        }

        namespace Finanzas {

            namespace CatalogosFinanzas {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaFinanzas {
                export const CecoConsultorio: string;
                export const CecoEcommerce: string;
                export const CecoFarmacias: string;
                export const DailyMarketOrder: string;
                export const EstatusFarmacia: string;
                export const FechaCierre: string;
                export const KeyState: string;
                export const LocalSap: string;
                export const MarketCluster: string;
                export const MarketDaily: string;
                export const Mercado: string;
                export const RegionCluster: string;
                export const Top360: string;
                export const Top550: string;
                export const TopMkt: string;
            }
        }

        namespace MarketIntelligence {

            namespace CatalogosMarketIntelligence {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaMarketIntelligence {
                export const Brick: string;
                export const Cluster: string;
                export const LocalSap: string;
                export const Nse: string;
            }
        }

        namespace Merchandising {

            namespace CatalogosMerchandising {
                export const Activo: string;
                export const Descripcion: string;
                export const DescripcionClave: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaMerchandising {
                export const Aretes: string;
                export const BusStop: string;
                export const CabecerasInstitucionales: string;
                export const Checkout: string;
                export const ClasificacionNacional: string;
                export const EndCap: string;
                export const ExhibidorGenerico: string;
                export const ExhibidorGloblaBrands: string;
                export const ExhibidorInstitucional: string;
                export const ExhibidorMascarillas: string;
                export const ExhibidorRetail: string;
                export const ExhibidorWellBeginnings: string;
                export const LocalSap: string;
                export const M2Calc: string;
                export const MedidaCabecera: string;
                export const MedidaCopete: string;
                export const MedidaGrafico: string;
                export const MedidasCanceleria: string;
                export const MedidasPecheras: string;
                export const PortaposterCanceleria: string;
                export const RampaDiscapa: string;
                export const RutaDli: string;
                export const ScreenDisplay: string;
                export const TamanoHeader: string;
                export const TamanoMiniheders: string;
                export const TipoSenalizacion: string;
                export const TipoSucursal: string;
                export const TramosFarma: string;
                export const TramosLisos: string;
            }
        }

        namespace Operaciones {

            namespace CatalogosOperaciones {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaOperaciones {
                export const DirectorRegional: string;
                export const EdoLocal: string;
                export const Geo: string;
                export const HorarioDyF: string;
                export const HorarioLv: string;
                export const HorarioS: string;
                export const LocalSap: string;
                export const MailGeo: string;
                export const Region: string;
                export const Zona: string;
            }
        }

        namespace RecursosHumanos {

            namespace CatalogosRH {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaRH {
                export const LocalSap: string;
                export const Plantilla: string;
                export const Vacantes: string;
            }
        }

        namespace TecnologiasInformacion {

            namespace CatalogosTI {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaTI {
                export const Emaillocal: string;
                export const Extension: string;
                export const LocalSap: string;
                export const Telefono: string;
                export const UsuarioGeo: string;
            }
        }

        namespace Tesoreria {

            namespace CatalogosTesoreria {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaTesoreria {
                export const Cajero: string;
                export const LocalSap: string;
            }
        }

        namespace UltimaMilla {

            namespace CatalogosUltimaMilla {
                export const Activo: string;
                export const Descripcion: string;
                export const IdClave: string;
                export const IdCons: string;
                export const IdtipoCatalogo: string;
                export const NombreTipoCatalogo: string;
            }

            namespace CategoriaUltimaMilla {
                export const CanalesDigitalesRappi: string;
                export const CanalesDigitalesUber: string;
                export const CierreServicio: string;
                export const ECommerceClickCollect: string;
                export const ECommerceDelivery: string;
                export const ECommerceTipo: string;
                export const Estado: string;
                export const Fijo99Min: string;
                export const FijoCid: string;
                export const FijoMu: string;
                export const Garantizado99Min: string;
                export const GarantizadoCid: string;
                export const GarantizadoMu: string;
                export const InicioServicio: string;
                export const LocalSap: string;
                export const OnDemandMu: string;
                export const OnDemandRappiCargo: string;
                export const Prov99Min: string;
                export const ProvCid: string;
                export const ProvMu: string;
                export const ProvRappiCargo: string;
                export const ServicioEfectivo1: string;
                export const ServicioEfectivo2: string;
                export const ServicioEfectivo3: string;
                export const ServicioEfectivo4: string;
                export const ServicioEfectivo5: string;
                export const ServicioEfectivo6: string;
                export const ServicioEfectivo7: string;
                export const ServicioEfectivo8: string;
                export const ServicioTarjeta10: string;
                export const ServicioTarjeta11: string;
                export const ServicioTarjeta12: string;
                export const ServicioTarjeta9: string;
                export const VentaTelf99Min: string;
                export const VentaTelfCid: string;
                export const VentaTelfMu: string;
                export const VentaTelfRappiCargo: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const BackToLogin: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const SuccessMessage: string;
            }

            namespace Login {
                export const FacebookButton: string;
                export const ForgotPassword: string;
                export const GoogleButton: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const BackToLogin: string;
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const AcceptTerms: string;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const BackToLogin: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
    }

    export declare namespace Navigation {
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace BasicProgressDialog {
            export const CancelTitle: string;
            export const PleaseWait: string;
        }

        namespace BulkServiceAction {
            export const AllHadErrorsFormat: string;
            export const AllSuccessFormat: string;
            export const ConfirmationFormat: string;
            export const ErrorCount: string;
            export const NothingToProcess: string;
            export const SomeHadErrorsFormat: string;
            export const SuccessCount: string;
        }

        namespace Dashboard {
            export const ContentDescription: string;
        }

        namespace Layout {
            export const FooterCopyright: string;
            export const FooterInfo: string;
            export const FooterRights: string;
            export const GeneralSettings: string;
            export const Language: string;
            export const Theme: string;
            export const ThemeBlack: string;
            export const ThemeBlackLight: string;
            export const ThemeBlue: string;
            export const ThemeBlueLight: string;
            export const ThemeGreen: string;
            export const ThemeGreenLight: string;
            export const ThemePurple: string;
            export const ThemePurpleLight: string;
            export const ThemeRed: string;
            export const ThemeRedLight: string;
            export const ThemeYellow: string;
            export const ThemeYellowLight: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace UserRoleDialog {
            export const DialogTitle: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    MasterDirectory['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Catalogos:{TipoCatalogos:{Activo:1,IdCons:1,IdtipoCatalogo:1,IdtipoCategoria:1,NombreTipoCategoria:1,TipoCatalogo:1},TipoCategorias:{Activo:1,IdtipoCategoria:1,TipoCategoria:1}},Comerciales:{CatalogosComerciales:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaComerciales:{Cajonera:1,ExhibMostrador:1,Hp1:1,Hp2:1,Hp3:1,Islas:1,Kioscos:1,LocalSap:1,M2Local:1,M2Pdv:1,MedidaCabecera:1,MuebleGenericos:1,No7:1,Refri4puertas:1,RefriMostradorFarma:1,SoapYGlory:1,Tabaquera:1,TabletasFujiFilm:1,TempoFarma:1,TirasImpulso:1,TotEspacioExhibFarm:1,TramosCajonera:1,TramosDermo:1}},Consultorios:{CatalogosConsultorios:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaConsultorios:{Benamedic:1,ConsulOperacion:1,HorarioD:1,HorarioLv:1,HorarioS:1,LocalSap:1}},Digital:{CatalogosDigital:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaDigital:{DirGoogle:1,Latitud:1,LinkGoogleMaps:1,LocalSap:1,Longitud:1}},Expansion:{CatalogosExpansion:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaExpansion:{Ciudad:1,Colonia:1,ColorMob:1,Comsuc:1,Cp:1,Dermo:1,Direccion:1,Estado:1,Farmacia:1,FechaApertura:1,FormatoFarmAlcance:1,Latitud:1,LocalSap:1,LocationType:1,Longuitud:1,NCajonesEstaciona:1,NExterior:1,Pantallas:1,ProvMobiliario:1,Reapertura:1,TipoEstaciona:1}},Finanzas:{CatalogosFinanzas:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaFinanzas:{CecoConsultorio:1,CecoEcommerce:1,CecoFarmacias:1,DailyMarketOrder:1,EstatusFarmacia:1,FechaCierre:1,KeyState:1,LocalSap:1,MarketCluster:1,MarketDaily:1,Mercado:1,RegionCluster:1,Top360:1,Top550:1,TopMkt:1}},MarketIntelligence:{CatalogosMarketIntelligence:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaMarketIntelligence:{Brick:1,Cluster:1,LocalSap:1,Nse:1}},Merchandising:{CatalogosMerchandising:{Activo:1,Descripcion:1,DescripcionClave:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaMerchandising:{Aretes:1,BusStop:1,CabecerasInstitucionales:1,Checkout:1,ClasificacionNacional:1,EndCap:1,ExhibidorGenerico:1,ExhibidorGloblaBrands:1,ExhibidorInstitucional:1,ExhibidorMascarillas:1,ExhibidorRetail:1,ExhibidorWellBeginnings:1,LocalSap:1,M2Calc:1,MedidaCabecera:1,MedidaCopete:1,MedidaGrafico:1,MedidasCanceleria:1,MedidasPecheras:1,PortaposterCanceleria:1,RampaDiscapa:1,RutaDli:1,ScreenDisplay:1,TamanoHeader:1,TamanoMiniheders:1,TipoSenalizacion:1,TipoSucursal:1,TramosFarma:1,TramosLisos:1}},Operaciones:{CatalogosOperaciones:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaOperaciones:{DirectorRegional:1,EdoLocal:1,Geo:1,HorarioDyF:1,HorarioLv:1,HorarioS:1,LocalSap:1,MailGeo:1,Region:1,Zona:1}},RecursosHumanos:{CatalogosRH:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaRH:{LocalSap:1,Plantilla:1,Vacantes:1}},TecnologiasInformacion:{CatalogosTI:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaTI:{Emaillocal:1,Extension:1,LocalSap:1,Telefono:1,UsuarioGeo:1}},Tesoreria:{CatalogosTesoreria:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaTesoreria:{Cajero:1,LocalSap:1}},UltimaMilla:{CatalogosUltimaMilla:{Activo:1,Descripcion:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaUltimaMilla:{CanalesDigitalesRappi:1,CanalesDigitalesUber:1,CierreServicio:1,ECommerceClickCollect:1,ECommerceDelivery:1,ECommerceTipo:1,Estado:1,Fijo99Min:1,FijoCid:1,FijoMu:1,Garantizado99Min:1,GarantizadoCid:1,GarantizadoMu:1,InicioServicio:1,LocalSap:1,OnDemandMu:1,OnDemandRappiCargo:1,Prov99Min:1,ProvCid:1,ProvMu:1,ProvRappiCargo:1,ServicioEfectivo1:1,ServicioEfectivo2:1,ServicioEfectivo3:1,ServicioEfectivo4:1,ServicioEfectivo5:1,ServicioEfectivo6:1,ServicioEfectivo7:1,ServicioEfectivo8:1,ServicioTarjeta10:1,ServicioTarjeta11:1,ServicioTarjeta12:1,ServicioTarjeta9:1,VentaTelf99Min:1,VentaTelfCid:1,VentaTelfMu:1,VentaTelfRappiCargo:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,SuccessMessage:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,PasswordConfirmMismatch:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = MasterDirectory.Texts;