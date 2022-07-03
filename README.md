I just noticed that database function I introduced in list manager is very useful so decided to make this.  
This is a tool to easily manage HR and GR quest ID lists.  
This is for personal use. There is no guarantee.  

# Build
After your build, create two empty folder to the same directory where exe created. Rename those `data` and `output`.

# Usage
If you already have `database.bin` from questlists_manager put it to `data` folder.  
Otherwise create a new database file. Check readme of questlists_manager for more details about it.  

Load database.  
Load decrypted `mhfdat.bin`.  
Add or delete quest, set normal or key or urgent flag to quests.  
Save and you'll get new `mhfdat.bin` inside `output` folder.

- None --- Just a normal quest.
- Key --- Set as a Key Quest
- Mark --- Mark quest like a Key Quest. Once you have cleared it it marked as "Cleared". But this is not a key quest.
- Urgent --- Set as a Urgent Quest. Normaly only 1 quest per Rank.

You can have up to 63 quests with a flag(Key+Urgent) in total (Thank you Malckyor for information).   
Setting Key or Urgent flag to GR quest doesn't do anything.

Adding a quest that doesn't exist in mhfinf or mhfdat is considered as none quest in game.  
To prevent this issue you need to add that quest to questlists. It doesn't matter which type(Evetn, Campaign, etc.).

# Known issues
- Every time you hit save button this app adds bytes of quest IDs at the end of file, this will result in increasing size of file a bit.
