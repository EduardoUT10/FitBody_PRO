using System;

namespace LineDietXF.Constants
{
    public static class Strings
    {
        // Generic strings
        public const string Generic_OK = "OK";
        public const string Generic_Cancel = "Cancelar";

        // Common strings - used multiple places
        public const string Common_WeightUnit_ImperialPounds = "libras";
        public const string Common_WeightUnit_Kilograms = "kilogramos";
        public const string Common_WeightUnit_Stones = "stones";
        public const string Common_WeightFormat = "{0:0.0}";
        public const string Common_Stones_WeightFormat = "{0:0}st {1:0.#}lbs";
        public const string Common_Stones_ShortWeightFormat = "{0:0.#}st";
        public const string Common_UpdateExistingWeight_Title = "¿Actualizar registro existente?";
        public const string Common_UpdateExistingWeight_Message = "El peso existente de {0:0.0} en {1:MM/dd/yyyy} será actualizado al peso de {2:0.0}.";
        public const string Common_SaveError = "Error al guardar";
        public const string Common_FatalError = "Error fatal";
        public const string Common_SettingWeightUnits_Title = "Configuración de unidad de peso";
        public const string Common_SettingWeightUnits_Message = "Fit Body está establecido actualmente {0} para la medida de pesos. Puedes cambiar esto yendo a la pestaña menú, y seleccionando configuraciones.";

        // Getting Started
        public static readonly string GettingStarted_Page1Title = $"Bienvenido a {Environment.NewLine} FIT BODY!";
        public const string GettingStarted_Page1Text = "Perder peso no tiene por qué ser complicado. Fit body hace que perder peso sea fácil :).";
        public const string GettingStarted_Page2Title = "Establece un objetivo";
        public const string GettingStarted_Page2Text = "La primera cosa que harás es establecer tu objetivo de peso y una fecha objetivo para lograrlo.";
        public const string GettingStarted_Page3Title = "Introduce tu peso diario";
        public const string GettingStarted_Page3Text = "Introduce tu peso cada mañana. Si lo ves verde entonces come normalito. Si lo ves rojo entonces come menos o haz más ejercicio.";
        public const string GettingStarted_Page4Title = "Stay on Track!";
        public const string GettingStarted_Page4Text = "Ajusta qué tan severa quieres tu dieta diariamente para mantener un historial y lograr tus objetivos de pérdida de peso!";

        // Daily Info Tab
        public const string DailyInfoPage_UnknownWeight = "???.?";
        public const string DailyInfoPage_Loading = "Cargando..";
        public const string DailyInfoPage_HowToEat_OnDiet = "Come algo ligero hoy";
        public const string DailyInfoPage_HowToEat_OffDiet = "Come normalito hoy";
        public const string DailyInfoPage_TodaysMessage_NoGoal = "Aún no tienes un objetivo establecido, vamos a establecer uno ahora!";
        public const string DailyInfoPage_TodaysMessage_NewGoal = "haz comenzado tu nueva dieta, vuelve cada mañana para mantener un historial de tu peso y mira si estás con una dieta ese día o puedes comer feliz :).";
        public const string DailyInfoPage_TodaysMessage_NoWeightToday = "Hora de introducir el peso de hoy amiwo :)";
        public const string DailyInfoPage_GoalEnd_Success = "Haz alcanzado tu objetivo! Puedes continuar usando Fit Body para mantener un registro del progreso de tu peso, o establecer un nuevo objetivo. Felicidades my friend :)!";
        public const string DailyInfoPage_GoalEnd_Failure = "Ups, parece que has fallado en tu objetivo ;C. Por qué no estableces un nuevo objetivo y lo intentas de nuevo?";
        public const string DailyInfoPage_ProgressSummary = "Tienes {0} {1:0.0} {2} desde que comenzaste tu objetivo actual hace {3} días. tienes {4} días restantes para perder {5:0.0} {2}. {6}";
        public const string DailyInfoPage_Stones_ProgressSummary = "Tienes {0} {1:0} stone(s) {2:0.0} libras, desde que empezaste tu objetivo actual hace {3} días. Tienes {4} días restantes para perder {5:0} stone(s), {6:0.0} libras. {7}";
        public const string DailyInfoPage_Summary_Gained = "ganado";
        public const string DailyInfoPage_Summary_Lost = "perdido";
        public const string DailyInfoPage_SummaryEnding_OnTrack = "Mantén ese buen trabajo my friend!";
        public const string DailyInfoPage_SummaryEnding_OffTrack = "Puedes hacerlo mijx ánimo!";

        // Graph/Listing Tab
        public const string GraphPage_ConfirmDelete_Title = "¿Borrar registro?";
        public const string GraphPage_ConfirmDelete_Message = "Borrar el registro para {0:MM/dd/yyyy}?";
        public const string GraphPage_DeleteFailed_Title = "Algo falló al eliminar";
        public const string GraphPage_DeleteFailed_Message = "Eliminado fallido, inténtalo de nuevo";
        public const string GraphPage_PlaceholderText_Loading = "Cargando..";
        public const string GraphPage_PlaceholderText_NoEntries = "Sin registros de peso para mostrar ;C";

        // Main Menu Tab
        public const string Menu_GettingStarted = "Vamos a empezar :)";
        public const string Menu_SetGoal = "Establecer Objetivo";
        public const string Menu_Settings = "Configuraciones";
        public const string Menu_Share = "Compartir";
        public const string Menu_LeaveAReview = "Deja un comentario";
        public const string Menu_SendFeedback = "Déjanos tu comentario";
        public const string Menu_About = "Acerca de";
        public const string Menu_Debug = "Menú de personalización";
        public const string Review_Failed_Title = "Deja tu comentario negativo :C";
        public const string Review_Failed_Message = "Incapáz de lanzar los comentarios. Por favor visita {0} a cambio y deja tu opinión. Muchas gracias!";
        public const string Review_Failed_Part_Android = "Google Play";
        public const string Review_Failed_Part_iOS = "the iTunes App Store";
        public const string Review_Failed_Part_Generic = "the app store";

        // Settings Page
        public const string Settings_WeightUnits = "Unidades de medida: ";
        public const string Settings_ImperialPound = "Libras";
        public const string Settings_Kilograms = "Kilogramos";
        public const string Settings_StonesAndPounds = "Stones";
        public const string Settings_ChangeWeightUnitsActionSheet = "Selecciona las unidades de peso a usar";
        public const string Settings_ChangeWeightUnits_GetWeightsError_Title = "Incapaz de obtener unidades de peso";
        public const string Settings_ChangeWeightUnits_GetWeightsError_Message = "Ocurrió un error tratando de conseguir tus registros de peso, no podemos continuar.";        
        public const string Settings_ChangeWeightUnits_ConvertWarning = "Convert weights to new units (ex: 100.0 pounds to 45.36 kilos)?";
        public const string Settings_ChangeWeightUnits_ConvertWarning_ConvertWeightValues = "Convert weight values";
        public const string Settings_ChangeWeightUnits_ConvertWarning_ChangeUnits = "Just change units";
        public const string Settings_ChangeWeightUnits_ConvertWeightValues_FatalError = "A fatal error occurred converting weight values, please contact support at smartypantscoding@gmail.com. Details: ";
        public const string Settings_ChangeWeightUnits_ChangeUnits_FatalError = "A fatal error occurred changing weight units, please contact support at smartypantscoding@gmail.com. Details: ";

        // Data Services
        public const string DataService_ChangeWeightAndGoalUnits_UnableToGetWeights = "Unable to get weights, cannot continue.";
        public const string DataService_ChangeWeightAndGoalUnits_FailedRemovingWeight = "Unable to update weight entry for {0}. Failed during remove.";
        public const string DataService_ChangeWeightAndGoalUnits_FailedAddingWeight = "Unable to update weight entry for {0}. Failed during add.";
        public const string DataService_ChangeWeightAndGoalUnits_FailedRemovingGoal = "Unable to update goal. Failed during remove.";
        public const string DataService_ChangeWeightAndGoalUnits_FailedAddingGoal = "Unable to update goal. Failed during add.";

        // Weight Entry Page
        public const string WeightEntryPage_Title_Add = "Enter Weight";
        public const string WeightEntryPage_Title_Update = "Update Weight";
        public const string WeightEntryPage_InvalidWeight_Title = "Invalid weight";
        public const string WeightEntryPage_InvalidWeight_Message = "Could not convert entered weight to a valid weight.";
        public const string WeightEntryPage_Save_RemoveExistingWeightFailed_Message = "An error occurred removing an existing weight entry for the selected date.";
        public const string WeightEntryPage_Save_AddingWeightFailed_Message = "An error occurred when adding the new weight entry.";
        public const string WeightEntryPage_Save_Exception_Message = "An exception occurred while saving your weight entry.";
        public const string WeightEntrylPage_WeightLabel = "Weight (in {0})";

        // Set Goal Page
        public const string SetGoalPage_InvalidWeight_Title = "Invalid weight";
        public const string SetGoalPage_InvalidWeight_Message = "Could not convert entered start and/or goal weight into a valid weight.";
        public const string SetGoalPage_GoalWeightGreaterThanStartWeight_Title = "Are you sure?";
        public const string SetGoalpage_GoalWeightGreaterThanStartWeight_Message = "Your goal weight is greater than your start weight. Are you sure your goal is to gain weight?";
        public const string SetGoalPage_Save_RemoveExistingWeightFailed_Message = "An error occurred removing an existing weight entry for the goal start date.";
        public const string SetGoalPage_Save_AddingWeightFailed_Message = "An error occurred adding a new weight entry for the goal start date.";
        public const string SetGoalPage_Save_AddingGoalFailed_Message = "An error occurred creating the new weight loss goal.";
        public const string SetGoalPage_Save_Exception_Message = "An exception occurred while saving your weight loss goal.";
        public const string SetGoalPage_StartWeightLabel = "Start Weight (in {0})";
        public const string SetGoalPage_GoalWeightLabel = "Goal Weight (in {0})";

        // Sharing
        public const string ShareTitle = "Check out Line Diet!";
        public const string ShareMessage = "You should check out Line Diet. It's a free app for simple diet tracking!";
    }
}