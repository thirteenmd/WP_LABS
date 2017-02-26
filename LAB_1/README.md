# LAB_1

The purpose of this laboratory work is to gain knowledge about basics of event-driven programming, understanding of window’s class and basic possibilities of Win32 API.

Implemented features:
* Made the Window responsive to being resized
* Made the elements interact and change other elements
* Changed behavior of different window actions

To make this Windows Application responsive to resizing I set the minimum size of the window to be 300x350 pixels by handling the event Load, then in the event ResizeEnd I checked what is the new width, if it is less or equal that 560 pixels (the width when the longest element, textBox, is not fully visible) then the position of all custom elements is changed to the left, if the width of the window is more than 560 then all elements go back to their initial places.

To make the elements interact with other elements I handled the event Click of the Button elements. Therefore when a button is clicked a message box appears, the window's text and background color changes and the text inside the text box is changed. The changes are different to each button.

I also changed the behavior of total three window actions: when the window is clicked on the background color changes to a random color, we can close the window by pressing the button 'x' and we can change the position of our form using the arrow keys.