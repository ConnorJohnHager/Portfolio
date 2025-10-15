## Aspect Ratio Enforcer Template
#### Generated in collaboration with ChatGPT
--- 
**Aspect Ratio Enforcer**: Would be attached to the main camera(s) to enforce a target aspect ratio (default 16:9, but can be modified) across different screen resolutions by adding letterboxing when necessary.

#### Notes regarding in-code comments:
* Any comment using "**Assign**" refers to a task to be completed in the Unity Editor.
* Any comment using "**CAN CHANGE**" should specify what parts of the code can be adjusted in that line to meet different needs.

#### Other notes:
* The script adjusts both the camera viewport and canvas positioning to ensure UI elements remain properly positioned within the visible gameplay area.
* The script runs in both Start() and Update() to handle real-time window resizing, but for performance optimization, you may want to only call Adjust() when the screen resolution actually changes.
---
#### Template developed by Connor Hager | Last updated on May 10, 2025