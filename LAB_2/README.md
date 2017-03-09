# LAB_2

Implemented features:

* Create a Windows application what will display a dialog box on some event (ex. on clicking some button)
* Add a system menu to your application with at least 3 items (add actions to that items)
* Hook keyboard input. Add 2 custom events for 2 different keyboard combinations (ex. change window background on ctrl+space)
* Add a scroll bar that will change any visible parameter of any other element (color of a text) OR other 2 scroll bars that will manage main window size or position
* Customize your application by adding an icon and using different cursor in application
* Add a listbox and attach some events when any element is accessed (clicked) 
* Use a scroll bar to scroll through application working space. Scroll should appear only when necessary (eg. when window width is smaller than 300px)

Like in the previous laboratory work, I chose to work in Visual Studio, I created a new Windows Form Application, added a button with the text "Show Message". Then I handled the event Click of this button in such manner, that when it is clicked a message box appears. Then I added a system menu to my application and added 3 item there: "Change Color", "Change Text" and "Change Size". After that I added actions to those items that are suggested by their name. I added two custom events for two different keyboard combinations: "Ctrl+U" - moves the window to the top left of the screen and "Ctrl+X" - Closes the application. I added a scroll bar that changes randomly the color of the background of the button. I customized my application by changing the cursor to "Cross" and added a custom icon. I added a list box with the elements "Up", "Down", "Left", and "Right" that, when clicked, change the position of the window according to their name. Then I added the scroll bars to my application, they appear only when there is no more space for the elements of the window.