﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings (channel = 6, sendInterval =(1.0f/29.0f))]
public class MyNetworkTransform : NetworkTransform {
}