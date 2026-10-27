# 🎯⚡ ArrowBlitz

**ArrowBlitz** is a challenging line-based puzzle game where players strategically activate animated arrows to clear the playfield. Avoid collisions, manage your lives, and complete all levels.

Developed with **Unity 6**, the game features smooth animations, intelligent collision detection, and a robust, scalable architecture.

---

## 🎮 About the Game

ArrowBlitz is a line-based puzzle game where players activate arrows by clicking on them.
Each arrow moves forward with an animation while gradually disappearing from its tail.

The core challenge lies in **timing your clicks correctly** to prevent collisions between arrows.

* When two arrows collide, you lose a life.
* Clear all arrows to win the level.

---

## ✨ Game Features

### 🎯 Core Mechanics

* ➡️ **Interactive Arrow System**
  Activate precise, smooth forward animations by clicking on arrows.
* 💥 **Smart Collision Detection**
  Advanced head-to-line collision system.
* ❤️ **Lives Management**
  Start with 5 lives and track remaining lives via heart-based UI.
* 🏆 **Win / Lose Conditions**
  Clear all arrows to win; lose all lives to fail the level.
* 📊 **Level Progression**
  10 carefully designed levels with increasing difficulty.

---

### 🎨 Visual Features

* 🎬 **Smooth Animations**
  DOTween-powered forward and backward arrow animations.
* 🎨 **Dynamic Color Feedback**
  Arrows change color on collision to clearly indicate errors.
* 📹 **Automatic Camera Adjustment**
  Camera automatically frames all arrows per level.
* ✨ **Arrow Head Tracking**
  A visual "head" object follows the arrow tip for better visibility.

---

## 🛠️ Tools & Packages Used

* ⚙️ **Unity Engine** — 6000.0.58f2 (Unity 6)
* 🔄 **DOTween** — Tween-based animations for arrow movement
* 🧰 **TriInspector** — Advanced Inspector UI
* 🎨 **Universal Render Pipeline (URP)** — Modern rendering
* 📝 **TextMeshPro** — Advanced text rendering for UI
* ➰ **Line Renderer** — Core system for rendering dynamic arrows

---

## 📦 Project Structure

```
Assets/
├── _Game/
│   ├── Scripts/
│   │   ├── Line/
│   │   └── UI/
│   ├── Resources/
│   │   ├── Levels/
│   │   └── Line/
│   ├── Scenes/
│   │   └── GameScene.unity
│   └── ...
└── ArrowBlitzKit/
```

---

## 🎯 How to Play

* 🎯 **Click to Activate** — Click on any arrow to activate it.
* 💥 **Avoid Collisions** — Each collision costs one life.
* ➡️ **Arrow Completion** — Arrows erase from the tail as they move.
* ❤️ **Manage Your Lives** — You start with 5 lives.
* 🏆 **Win Condition** — Complete all arrows without collisions.
* 💔 **Lose Condition** — Lose all 5 lives.

---

## 🕹️ Controls

* 🖱️ **Mouse / Touch** — Click or tap an arrow to activate
* ⏸️ **No Re-activation** — Moving arrows cannot be activated again
* 🎯 **Strategy** — Analyze arrow placement carefully before clicking

---

## 🚀 Getting Started

1. Open the project in **Unity Hub** (Unity 6000.0.58f2)
2. Open the main scene: `Assets/_Game/Scenes/GameScene.unity`
3. Press **Play**

---

## 📜 Developer

Made with ❤️ by **Dipanjan**
Package: `com.dipanjan.arrowblitz`
