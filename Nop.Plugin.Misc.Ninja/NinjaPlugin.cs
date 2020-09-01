using System;
using System.Collections.Generic;
using System.Text;
using Nop.Plugin.Misc.Ninja.Data;
using Nop.Services.Common;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.Ninja
{
    public class NinjaPlugin:BasePlugin,IMiscPlugin
    {
        public override string GetConfigurationPageUrl()
        {
            return base.GetConfigurationPageUrl();
        }
        private NinjaCmsObjectContext _context;
        public NinjaPlugin(NinjaCmsObjectContext context)
        {
            _context = context;
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.UnInstall();
            base.Uninstall();
        }

    }
}
