# BlipTune
This project was built as a Senior Capstone requirement for the Music Technnology major at the University of Illinois at Urbana-Champaign

## Basic Controls
- The **frequency** of each blip is controlled by its height in space. Higher elevation = higher frequency.
- The **amplitude** of each blip is controlled by its distance from the user (*Smash Mode for the default blip is a special case*)
- The **directionality** of audio for each blip is controlled by the Microsoft HRTF Spatializer. This anchor's each blip's audio in space and creates a very convincing 3D audio effect
  - The MS HRTF Spatializer also adds a small amount of doppler effect to the audio emitted from each blip
- Each blip has 3 main controls attached to them described under ["The Blip Interface"](#The-Blip-Interface) heading
- The user also has access to a hand menu with 3 controls described under ["The Hand Menu"](#The-Hand-Menu) heading

### Main Project Goals
- Create a unique approach to audio exploration which fosters discovery led by the ears 
- Build an audio environment which is inviting and conducive of experimentation for musicians of all backgrounds and skill types 
- Design an application which demonstrates the use of emerging technology as a means for music creation and exploration

### Constraints
- **No set tunings**: People of different backgrounds may use different tunings
- **No Forced Repetition**: Repetitive acts brew stale ideas and reduce the degree of creativity
- **No Interval Palette**: This would discourage the exploration of imperfect intervals and beating 

## The Blip Interface
![A sphere with button and slider attached](https://github.com/CJRosas/BlipTune/blob/master/Media/Screenshot%202022-04-25%20233255.png) <br />
The interface on each spherical "Blip" was designed to maximize creative possibility and discoverability in as few physical buttons as possible. 
- **Toggle On/Off Button**: Causes the blip to emit/stop emitting audio
- **Slider**: Interpolates the blip's emitting audio between a sine wave (slider fully left) and a sawtooth wave (slider fully right)
- **"X" button (on back of blip)**: Deletes the blip it is attached to

## The Hand Menu
![A stack of 3 buttons](https://github.com/CJRosas/BlipTune/blob/master/Media/Screenshot%202022-04-25%20233329.png)
The hand menu appears on the ulnar side of the user's hand when either the user places either plam facing upward (left priority).
- **Add Blip Button**: Instantiates the blip prefab and places it at the location in space that the first blip appeared
- **Smash Mode Button**: Allows the user to control the amplitude of the first default spawned blip via the distance of either hand from the blip. The closer the user's hand is to the blip, the louder it becomes. Then as the hand moves away, the amplitude decreases.
- **Exit Button**: Opens an additional "Exit BlipTune?" dialogue <br/>
![Confirm Exit Button](https://github.com/CJRosas/BlipTune/blob/master/Media/Screenshot%202022-04-26%20000906.png)
