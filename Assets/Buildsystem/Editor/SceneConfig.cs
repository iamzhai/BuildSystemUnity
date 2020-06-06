﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

[Serializable]
public class SceneConfig
{
    [XmlArray("SceneConfiguration")]
    public List<SceneData> sceneConfigs;
}