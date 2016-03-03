# Asp.net 5 Notes
---

### Various commands
---

code . = opens VSCode in current directory

dnu restore = restores all nugget packages for a project

dnx web = runs the web server (kestrel)

  "commands": {
    "web": "Microsoft.AspNet.Server.Kestrel",
    "ef": "EntityFramework.Commands"
  },

**Allows to run migrations from the command line**

	dnx ef [options] [command]

	dnx ef migrations add [insert name here]

	dnx ef migrations remove [insert name here]

---