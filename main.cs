 public void EnvoyerNotification(string message)
 {
     // Vérifier si des gestionnaires sont enregistrés
     if (gestionnaireNotifications != null)
     {
         Console.WriteLine("--- Envoi de notification ---");
         gestionnaireNotifications(message); // Appelle tous les gestionnaires
         Console.WriteLine("--- Fin de notification ---");
     }
     else
     {
         Console.WriteLine("Aucun gestionnaire de notification enregistré.");
     }
 }