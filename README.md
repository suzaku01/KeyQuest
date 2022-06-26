I just noticed that database function I introduced in list manager is very useful so decided to make this.  
This is a tool to easily manage HR and GR quest ID lists.

# Build
After your build, create two empty folder to the same directory where exe created. Rename those `data` and `output`.

# Usage
If you already have `database.bin` from questlists_manager put it to `data` folder.  
Othereise create new database file. Check readme of questlists_manager for more details about it.  

Load decrypted `mhfdat.bin`.  
Add or delete quest, set normal or key or urgent flag to quests.  
Save and you'll get new `mhfdat.bin` inside `output` folder.
