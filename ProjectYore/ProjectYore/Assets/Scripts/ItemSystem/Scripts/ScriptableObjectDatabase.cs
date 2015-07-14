using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectYore
{
    public class ScriptableObjectDatabase<T> : ScriptableObject where T : class
    {
        [SerializeField]
        protected List<T> database = new List<T>();

        public void Add(T item)
        {
            database.Add(item);
            EditorUtility.SetDirty(this);
        }

        public void Insert(int index, T item)
        {
            database.Insert(index, item);
            EditorUtility.SetDirty(this);
        }

        public void Remove(T item)
        {
            database.Remove(item);
            EditorUtility.SetDirty(this);
        }

        public void Remove(int index)
        {
            database.RemoveAt(index);
            EditorUtility.SetDirty(this);
        }

        public int Count
        {
            get { return database.Count; }
        }

        public T Get(int index)
        {
            return database.ElementAt(index);
        }

        public void Replace(int index, T item)
        {
            database[index] = item;
            EditorUtility.SetDirty(this);
        }

        public static U GetDatabase<U>(string dbpath, string dbname) where U: ScriptableObject
        {
            string dbFullPath = @"Assets/" + dbpath + "/" + dbname;

            U db = AssetDatabase.LoadAssetAtPath(dbFullPath, typeof(U)) as U;

            if (db == null)
            {
                //check to see if the folder exists
                if (!AssetDatabase.IsValidFolder(@"Assets/" + dbpath))
                {
                    AssetDatabase.CreateFolder(@"Assets", dbpath);
                    Debug.Log("created the database folder");
                }
                db = ScriptableObject.CreateInstance<U>();
                AssetDatabase.CreateAsset(db, dbFullPath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            return db;
        }
    }
}