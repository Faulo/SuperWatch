/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/

using System;
using UnityEngine;
using OVRTouchSample;

namespace OculusSampleFramework {
    public class DistanceGrabbable : OVRGrabbable {
        public string m_materialColorField;

        GrabbableCrosshair m_crosshair;
        GrabManager m_crosshairManager;
        [SerializeField]
        public MeshFilter meshFilter;

        MaterialPropertyBlock m_mpbCurrent;
        MaterialPropertyBlock m_mpbBackup;


        public bool InRange {
            get { return m_inRange; }
            set {
                m_inRange = value;
                RefreshCrosshair();
            }
        }
        bool m_inRange;

        public bool Targeted {
            get { return m_targeted; }
            set {
                m_targeted = value;
                RefreshCrosshair();
            }
        }
        bool m_targeted;

        protected override void Start() {
            base.Start();
            m_crosshair = gameObject.GetComponentInChildren<GrabbableCrosshair>();

            m_crosshairManager = FindObjectOfType<GrabManager>();

            RefreshCrosshair();
        }

        void RefreshCrosshair() {
        }
    }
}
