namespace youtube_dl_service
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller_youtube_dl = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller_youtube_dl = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller_youtube_dl
            // 
            this.serviceProcessInstaller_youtube_dl.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller_youtube_dl.Password = null;
            this.serviceProcessInstaller_youtube_dl.Username = null;
            // 
            // serviceInstaller_youtube_dl
            // 
            this.serviceInstaller_youtube_dl.ServiceName = "Youtube_dl_remote";
            this.serviceInstaller_youtube_dl.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller_youtube_dl,
            this.serviceInstaller_youtube_dl});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller_youtube_dl;
        private System.ServiceProcess.ServiceInstaller serviceInstaller_youtube_dl;
    }
}