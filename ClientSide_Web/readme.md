# jQuery
https://jquery.com/

- JavaScript Lightweight Library for Document-Object-Model (DOM) Manipulation
	- DOM: Process of accesign HTML elements using JavaScript and performing following operations on them
		- Read/Write Values
		- Raising Events
		- Dynamically Gnerating HTML
	- Reading DOM Values and posting them to Server using HTTP Calls 

- HTML UI Elements
	- input Elements
		- TextBox, Radio Button, CheckBox, Date, Month, Time, Color, Week, Range, button
        - Property System
            - 'value', read write data from and to HTML Input Element
            - min, max, minlength, maxlength, required
                - Validation Properties
            -  The 'style' property
                - Look and Feel and Dimensions
	- Layout Elements
		- div, table, paragraph (p), article, etc.
        - Property System
            - The 'style' property
                - Look and Feel and Dimensions
	- Headers
		- h1,h2,h3,h4,h5,h6
	- Collections
		- select
		- ul
		- ol
```` html
<h1>Just SHowing HTML Elements</h1>
    <table>
        <tr>
            <td>
                Text Element
            </td>
            <td>
                <input type="text" />
            </td>
        </tr>
        <tr>
            <td>
                Radio
            </td>
            <td>
                <input type="radio" />
            </td>
            <td>
                CheckBox
            </td>
            <td>
                <input type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                Names
            </td>
            <td>
                <select>
                    <option>1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
                    <option>5</option>
                </select>
            </td>
        </tr>
    </table>
    <hr/>
    <div>
        <h2>The Div Tag</h2>
        <p>
            The Paragraph
        </p>
        <strong>
            This is Bold
        </strong>
        <input type="button" value="ddd"/>
    </div>

````

# Using or Accessing HTML Elements (DOM) in jQuery
- The jQuery is read as '$' 
- Object
    - Everything is Object
        - Number Type
        - String Type
        - Date
        - Boolean
        - object
        - Array
    - The Declaration of the varibale takes place using 'var'
        - The 'var' is late binding
        - The Function/Module Scope variable. Once it is declaraed, it will be available throught the function / module
        - e.g.
            - var x;
                - x can store 'anything' in it
                    - number, string, date, object, array, function, etc.
                - x will keep overwritting its value
                    - e.g.
                        - var x  = 10; // on line 10
                        - x = 'Mahesh'; // on line 11
                            - 10 will be overwritten by Mahesh
            - The 'Array' is the 'Only-Collection-Type'
                - var x = []; This is an empty array and can have any data in it;
                    - Array is an object that has methods
                        - push(), pop(), sort(), indexOf(), lastIndexOf(), etc.
            - The 'string' object
                - var x = "ddddd";
                    - The 'x' will become a string and this will have access of string methods
                        - length, toUpperCase(), toLowerCase(), etc.    
            - The '{}' aka Object Literal aka JSON Object
                - var x = {};
                    - x can have public properties and methods
                    - var x = {id:11, name:'aaa'}; 
                        - Declaration of properties while declaring object
                    - OR
                    - var x = {};
                        - add properties explicitly
                            - x.id = 222;
                            - x.name = "ddd";
- Methods
    - val(), read write value,
    - text(), read text
    - html(), read HTML
    - addCss(), dynamically add a CSS   to HTMl Element
    - removeCss()
    - addClass(), add a css class dunamically
    - removeClass()
    - PLugIn Methods
        - $.each()
            - a loop to iterate over the collection
        - $.ajax()
            - To Make HTTP Call to REST APIs

- Event subscription methods
    - on(), subscribe an event on HTML Element
    - off(), unregister (or de-subscribe) and event from HTML Element 
- Selectors
    - A Mechanism to Query HTML Document to extract (or read) HTML DOM Elements
    - The 'id' selector, used to select HTML Element using its 'id' attribute
```` html
   <input type="text" id="txt"/>
````
        - Use the 'id' selector as follows, this return 'a single HTML Element' since the 'id' is unique 
```` javascript
    $("#txt") 
````
    - The 'class' select, this is used to extract 'elements' based on class name
    - This will return an array of elements
```` html
 <input type="text" id="txt1" class="c1"/>
 <input type="text" id="txt2" class="c1"/>
 <input type="text" id="txt3" class="c1"/>
````
    - To read elements based on class use the following
```` javascript
    $(".c1")
````
    - The 'tag' selectors, read HTML elements having same tag
    - Return an array of elements
    
```` html
 <input type="text" id="txt1" class="c1"/>
 <input type="text" id="txt2" class="c1"/>
 <input type="button" id="btn" class="c1"/>
  <input type="radio" id="txt3" class="c1"/>
````

    - read all input elements by 'input' tag
  
```` javascript    
    $("input")
````
    - Complex Selectors with its combinitions

```` html
 <input type="text" id="txt1" class="c1"/>
 <input type="text" id="txt2" class="c1"/>
 <input type="button" id="btn" class="c1"/>
  <input type="radio" id="txt3" class="c1"/>
````
    - read input elements of the type 'text'

```` javascript
    $('input[type="text"]')
````

    - Read elements with tag and class. E.g. only input elements with class as 'c1'
```` html
  <input type="text" id="txt1" class="c1"/>
 <input type="text" id="txt2" class="c1"/>
 <input type="button" id="btn" class="c1"/>
  <input type="radio" id="txt3" class="c4"/>
  <input type="text" id="txt1" class="c2"/>
  <div class="c1"></div>

````
    - using the tag and class selector in combinition
```` javascript
    $("input.c1")
````

- Reading and Writing Data From and To text element

```` javascript
    $(document).ready(function(){
        // Read value of txt1 and store it in x
       var x = $("#txt1").val(); 
       // add 100 to txt2 element
       $("#txt2").val(100);
    });
````

- Attaching an event to button
    - Use the 'on()' method
        - on('NAME-OF-EVENT-AS-STRING', the Function CallBack that will be executed)
```` javascript
    $(document).ready(function(){
        $("#btn").on('click', function(){......LOGIC.....});

        // Detach event

        $("#btn").off('click');
    });
````
    - e.g.
        - $("#txt").on('change', function(){.....});
        - $("#lst").on('change', function(){.....});
        - $("#dv").on('mouseenter', function(){......});
        - $("#dv").on('mouseleave', function(){......});
    - $(document).ready(); The HTML Page is loaded in browser
- To Generate HTNL Dunamically
```` javascript
    // 1. declare an array
    var Emps = []; // Data Array
    $.each(0, Emps.length, function(){
         // LOGIC to Generate HTML Dynamically   
    });
```

- TO make an ajax call
    - USe $.ajax().done().error();
        - ajax(), intiate the call to REST APIs
        - .done(), execute a function if the call to REAT API is successful
        - .error(), execute a function, if the call to REST API fails
 
```` javascript
   $(document).ready(function(){
      $.ajax({
        url: 'URL-OF-REST-API',
        type:'HTTP-METHOD-TYPE e.g. Get, Post, Puit,Delete. The default is Get',
        data: {THE JSON THAT IS POSTED  TO REST API with POST or PUT Call},
        Content-Type: 'MIME-TYPE-OR-MEDIA-FORMATTER, the format of data which is posetd to server',
        datatype: 'Data Type of the data, html, xml, json'
      }).done(function(response){
         // Process the 'response'
      }).error(function(error){
        // Show the 'error'
      });
   });
````