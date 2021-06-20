using System.Collections.Generic;

namespace BatchFileRenamer
{
    public class Localization
    {

        public Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();
        public Localization()
        {
            Dictionary<string, string> tDE = new Dictionary<string, string>();
            Dictionary<string, string> tEN = new Dictionary<string, string>();
            Dictionary<string, string> tFR = new Dictionary<string, string>();
            tDE.Add("typFilename", "Dateiname");
            tEN.Add("typFilename", "Filename");
            tFR.Add("typFilename", "Nom de fichier");
            tDE.Add("typDirname", "Ordnername");
            tEN.Add("typDirname", "Directoryname");
            tFR.Add("typDirname", "Nom de dossier");
            tDE.Add("list_col_before", "Vorher");
            tEN.Add("list_col_before", "Before");
            tFR.Add("list_col_before", "Devant");
            tDE.Add("list_col_after", "Nachher");
            tEN.Add("list_col_after", "After");
            tFR.Add("list_col_after", "Après");
            tDE.Add("files", " Dateien");
            tEN.Add("files", " files");
            tFR.Add("files", " des dossiers");
            tDE.Add("dirs", " Verzeichnisse");
            tEN.Add("dirs", " directories");
            tFR.Add("dirs", " dossiers");
            tDE.Add("error", "Fehler");
            tEN.Add("error", "Error");
            tFR.Add("error", "Erreur");
            tDE.Add("error_pathnotexist", "Dieses Verzeichnis existiert nicht!");
            tEN.Add("error_pathnotexist", "This directory does not exist!");
            tFR.Add("error_pathnotexist", "Ce répertoire n'existe pas!");
            tDE.Add("rename_sure", " werden umbenannt!\nWirklich fortfahren ? ");
            tEN.Add("rename_sure", " will be renamed!\nProceed ? ");
            tFR.Add("rename_sure", " sera renommé!\nProcéder ? ");
            tDE.Add("rename_sure_title", "Sicher ? ");
            tEN.Add("rename_sure_title", "Sure ? ");
            tFR.Add("rename_sure_title", "Sûr ? ");
            tDE.Add("rename_nothingtodo", "Durch die gesetzten Regeln gibt es nichts umzubenennen.");
            tEN.Add("rename_nothingtodo", "The rules does not affect anything.");
            tFR.Add("rename_nothingtodo", "Les règles n'affectent rien.");
            tDE.Add("rename_nothingtodo_title", "Nichts zu tun!");
            tEN.Add("rename_nothingtodo_title", "Nothing to do!");
            tFR.Add("rename_nothingtodo_title", "Rien à faire!");
            tDE.Add("btnOpenDir_tooltip", "Verzeichnis im Explorer öffnen");
            tEN.Add("btnOpenDir_tooltip", "Open directory in explorer");
            tFR.Add("btnOpenDir_tooltip", "Ouvrir le répertoire dans l'explorateur");
            tDE.Add("label_rule3_explanation_dir", "Füge einen Text an jedes Verzeichnis");
            tEN.Add("label_rule3_explanation_dir", "Add text to every directory");
            tFR.Add("label_rule3_explanation_dir", "Ajouter du texte à chaque répertoire");
            tDE.Add("label_rule3_explanation_file", "Füge einen Text an jede Datei");
            tEN.Add("label_rule3_explanation_file", "Add text to every file");
            tFR.Add("label_rule3_explanation_file", "Ajouter du texte à chaque fichier");
            tDE.Add("btnResetRules_tt", "Regeln zurücksetzen");
            tEN.Add("btnResetRules_tt", "reset rules");
            tFR.Add("btnResetRules_tt", "Réinitialiser les règles");
            tDE.Add("revert_rename_dialog_msg", "Möchten Sie den Vorgang für %n Elemente wirklich rückgängig machen?");
            tEN.Add("revert_rename_dialog_msg", "Do you really want to revert the changes of %n elements?");
            tFR.Add("revert_rename_dialog_msg", "Voulez-vous vraiment annuler les modifications de %n éléments?");
            tDE.Add("revert_rename_dialog_success_msg", "%n %e zurückgesetzt");
            tEN.Add("revert_rename_dialog_success_msg", "%n %e reverted");
            tFR.Add("revert_rename_dialog_success_msg", "%n %e réinitialisés");

            tDE.Add("btnRevert_files_tt", "Das Umbenennen der Dateien rückgängig machen");
            tEN.Add("btnRevert_files_tt", "Revert the renaming of all changed files");
            tFR.Add("btnRevert_files_tt", "Rétablir le renommage de tous les fichiers modifiés");
            tDE.Add("btnRevert_dirs_tt", "Das Umbenennen der Verzeichnisse rückgängig machen");
            tEN.Add("btnRevert_dirs_tt", "Revert the renaming of all changed directories");
            tFR.Add("btnRevert_dirs_tt", "Rétablir le renommage de tous les répertoires modifiés");
            tDE.Add("revert_rename_dialog_error_msg", "%n %e konnten nicht rückgängig gemacht werden!");
            tEN.Add("revert_rename_dialog_error_msg", "%n %e could not been reverted!");
            tFR.Add("revert_rename_dialog_error_msg", "%n %e n'ont pas pu être rétablis!");

            tDE.Add("settings_helpContextIntegration", "Fügt eine Funktion im Windows-Explorer Rechtsklickmenü ein,\num Batch FileRenamer vom jeweiligen Pfad auszuführen.");
            tEN.Add("settings_helpContextIntegration", "Adds an entry in windows-explorer rightclick menu,\nto start Batch FileRenamer from a respective location.");
            tFR.Add("settings_helpContextIntegration", "Ajoute une entrée dans le menu contextuel de l'explorateur Windows,\ne pas démarrer Batch File Renamer à partir d'un emplacement respectif.");
            tDE.Add("context_menu_label", "Batch FileRenamer starten");
            tEN.Add("context_menu_label", "start batch fileRenamer");
            tFR.Add("context_menu_label", "commencer batch fileRenamer");
            tDE.Add("lblVersion_tooltip", "Öffne Github-Repository");
            tEN.Add("lblVersion_tooltip", "Open Github-Repository");
            tFR.Add("lblVersion_tooltip", "Ouvrir Github-Repository");
            tDE.Add("lblCreator_tooltip", "Öffne Entwickler Webseite");
            tEN.Add("lblCreator_tooltip", "Open Developer Website");
            tFR.Add("lblCreator_tooltip", "Ouvrir le site Web du développeur");

            translations.Add("de", tDE);
            translations.Add("en", tEN);
            translations.Add("fr", tFR);
        }

        public string getLocStr(string key, string lang = null)
        {
            if (lang == null)
            {
                lang = Properties.Settings.Default.language;
            }
            if(translations.ContainsKey(lang))
            {
                if(translations[lang].ContainsKey(key))
                {
                    return translations[lang][key];
                }
            }
            return "missing translation %"+lang+"%.%" + key + "%";
        }
    }
}
