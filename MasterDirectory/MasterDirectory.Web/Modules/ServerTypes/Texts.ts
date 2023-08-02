﻿import { proxyTexts } from "@serenity-is/corelib/q";

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

        namespace Merchandising {

            namespace CatMerchandising {
                export const Aretes: string;
                export const BusStop: string;
                export const CabecerasInstitucionales: string;
                export const Checkout: string;
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
                export const NombreAretes: string;
                export const NombreBusStop: string;
                export const NombreCabecerasInstitucionales: string;
                export const NombreCheckout: string;
                export const NombreEndCap: string;
                export const NombreExhibidorGenerico: string;
                export const NombreExhibidorGloblaBrands: string;
                export const NombreExhibidorInstitucional: string;
                export const NombreExhibidorMascarillas: string;
                export const NombreExhibidorRetail: string;
                export const NombreExhibidorWellBeginnings: string;
                export const NombreM2Calc: string;
                export const NombreMedidaCabecera: string;
                export const NombreMedidaGrafico: string;
                export const NombreMedidasCanceleria: string;
                export const NombreMedidasPecheras: string;
                export const NombrePortaposterCanceleria: string;
                export const NombreScreenDisplay: string;
                export const NombreTamanoHeader: string;
                export const NombreTamanoMiniHeader: string;
                export const NombreTipoSenalizacion: string;
                export const NombreTipoSucursal: string;
                export const NombreTramosFarma: string;
                export const NombreTramosLisos: string;
                export const PortaposterCanceleria: string;
                export const RutaDli: string;
                export const ScreenDisplay: string;
                export const TamanoHeader: string;
                export const TamanoMiniheders: string;
                export const TipoSenalizacion: string;
                export const TipoSucursal: string;
                export const TramosFarma: string;
                export const TramosLisos: string;
            }

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

    MasterDirectory['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Catalogos:{TipoCatalogos:{Activo:1,IdCons:1,IdtipoCatalogo:1,IdtipoCategoria:1,NombreTipoCategoria:1,TipoCatalogo:1},TipoCategorias:{Activo:1,IdtipoCategoria:1,TipoCategoria:1}},Merchandising:{CatMerchandising:{Aretes:1,BusStop:1,CabecerasInstitucionales:1,Checkout:1,EndCap:1,ExhibidorGenerico:1,ExhibidorGloblaBrands:1,ExhibidorInstitucional:1,ExhibidorMascarillas:1,ExhibidorRetail:1,ExhibidorWellBeginnings:1,LocalSap:1,M2Calc:1,MedidaCabecera:1,MedidaCopete:1,MedidaGrafico:1,MedidasCanceleria:1,MedidasPecheras:1,NombreAretes:1,NombreBusStop:1,NombreCabecerasInstitucionales:1,NombreCheckout:1,NombreEndCap:1,NombreExhibidorGenerico:1,NombreExhibidorGloblaBrands:1,NombreExhibidorInstitucional:1,NombreExhibidorMascarillas:1,NombreExhibidorRetail:1,NombreExhibidorWellBeginnings:1,NombreM2Calc:1,NombreMedidaCabecera:1,NombreMedidaGrafico:1,NombreMedidasCanceleria:1,NombreMedidasPecheras:1,NombrePortaposterCanceleria:1,NombreScreenDisplay:1,NombreTamanoHeader:1,NombreTamanoMiniHeader:1,NombreTipoSenalizacion:1,NombreTipoSucursal:1,NombreTramosFarma:1,NombreTramosLisos:1,PortaposterCanceleria:1,RutaDli:1,ScreenDisplay:1,TamanoHeader:1,TamanoMiniheders:1,TipoSenalizacion:1,TipoSucursal:1,TramosFarma:1,TramosLisos:1},CatalogosMerchandising:{Activo:1,Descripcion:1,DescripcionClave:1,IdClave:1,IdCons:1,IdtipoCatalogo:1,NombreTipoCatalogo:1},CategoriaMerchandising:{Aretes:1,BusStop:1,CabecerasInstitucionales:1,Checkout:1,EndCap:1,ExhibidorGenerico:1,ExhibidorGloblaBrands:1,ExhibidorInstitucional:1,ExhibidorMascarillas:1,ExhibidorRetail:1,ExhibidorWellBeginnings:1,LocalSap:1,M2Calc:1,MedidaCabecera:1,MedidaCopete:1,MedidaGrafico:1,MedidasCanceleria:1,MedidasPecheras:1,PortaposterCanceleria:1,RutaDli:1,ScreenDisplay:1,TamanoHeader:1,TamanoMiniheders:1,TipoSenalizacion:1,TipoSucursal:1,TramosFarma:1,TramosLisos:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,SuccessMessage:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,PasswordConfirmMismatch:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = MasterDirectory.Texts;