﻿namespace YamlUserModel
{
    public class GameObject: YamlObjBase
    {
        public InFileHold m_PrefabParentObject { get; set; }
        public InFileHold m_PrefabInternal { get; set; }
        public long serializedVersion { get; set; }
        public Component[] m_Component { get; set; }
        public int m_Layer { get; set; }
        public string m_Name { get; set; }
        public string m_TagString { get; set; }
        public InFileHold m_Icon { get; set; }
        public int m_NavMeshLayer { get; set; }
        public int m_StaticEditorFlags { get; set; }
        public int m_IsActive { get; set; }
    }
}