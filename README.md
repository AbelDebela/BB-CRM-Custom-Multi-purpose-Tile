# BB-CRM- Multi-purpose Custom Tile

After working on a couple of custom constituent tile projects, I was wondering if I can make a multi-purpose tile or a tile that serves different purpose based on user needs. (Something you can change easily without modifying catalog specs). After thinking about it over the weekend, I came up with this tile where the view spec picks SQL logic from custom configuration table and expose data into constituent page.

Here is the assumption, the tile will have 5 line of information. Line1 – Line5. The SQL logic saved in custom configuration table fetches data as XML & nvarchar string when executed from the tile spec. 


Both the tile header and “No record found” messages can be set from the dynamic SQL stored in configuration table. Here is full source code (catalog, UI & HTML forms).

![multipurposetilesumary](https://user-images.githubusercontent.com/11167096/39772283-b679e9e6-52a9-11e8-8581-8c658217ef7b.PNG)

![multipurposetilesaveform](https://user-images.githubusercontent.com/11167096/39772301-c4498efa-52a9-11e8-8377-429d3ccc3513.PNG)
