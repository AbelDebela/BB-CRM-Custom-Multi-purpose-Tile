# BB-CRM-Custom-Multi-purpose-Tile

After working on a couple of custom constituent tile projects, I was wondering if I can make a multi-purpose tile or a tile that serves different purpose based on user needs. (Something you can change easily without modifying catalog specs). After thinking about it over the weekend, I came up with this tile where the view spec picks SQL logic from custom configuration table and expose data into constituent page.

Here is the assumption, the tile will have 5 line of information. Line1 – Line5. The SQL logic saved in custom configuration table fetches data as XML & nvarchar string when executed from the tile spec. 

Both the tile header and “No record found” messages can be set from the dynamic SQL stored in configuration table. Full source code (catalog, UI & HTML forms) is in GitHub. 


