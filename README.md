# RetroArch Cheevos API in C#

## Overview
RetroArch Cheevos API is a **C# implementation** of the RetroAchievements API, designed to integrate with RetroArch for tracking and retrieving achievement data. This is a **work in progress** and is not yet complete.

## Features
- 🏆 **Achievements API**: Retrieve information on achievements and unlocks.
- 🎮 **Games API**: Fetch game details, achievement counts, and rankings.
- 📡 **Feeds API**: Planned support for tracking activity feeds.
- 📝 **Events API**: Integration for weekly events.
- ⚙️ **Systems API**: System based info.
- 🎟️ **Tickets API**: Manage achievement submissions and disputes.
- 👤 **Users API**: Retrieve user statistics and progress.

## Usage
Install via nuget: https://www.nuget.org/packages/PolyhydraGames.RACheevos
The **Cheevos API** is implemented as a **C# class library** that can be used in your own projects.
To use the API, create an instance of the relevant **Cheevos** class.

### Available Methods
#### 🏆 Achievements
- `GetAchievementUnlocks`

#### 🎮 Games
- `GetGame`
- `GetGameExtended`
- `GetAchievementCount`
- `GetAchievementDistribution`
- `GetGameRankAndScore`

#### Other APIs (WIP)
- **📡 Feeds**
- **📝 Events**
- **⚙️ Systems**
- **🎟️ Tickets**
- **👤 Users**

## Goals & Roadmap
- [ ] **Implement all API endpoints**
- [ ] **Create a GitHub Action to build a NuGet package**
- [ ] **Automate NuGet package publishing via GitHub Actions**

## Contributing
💡 Contributions are welcome! If you'd like to contribute to the API, feel free to submit issues, feature requests, or pull requests.

## License
📜 This project is licensed under the **MIT License**.

## Contact
For questions or suggestions, feel free to open an issue or reach out on GitHub.
