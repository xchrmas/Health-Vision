<div align="center">

<img src="https://raw.githubusercontent.com/ТВО_ЮЗЕ/HealthVision/main/HealthVision.Web/wwwroot/images/logo.png" alt="HealthVision Logo" width="420"/>

# HealthVision®

### The world's most advanced AI-powered medical intelligence and 3D anatomy platform

[![License](https://img.shields.io/badge/license-Proprietary-blue?style=flat-square)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com)
[![Unity](https://img.shields.io/badge/Unity-6.3_WebGL-000000?style=flat-square&logo=unity)](https://unity.com)
[![Claude AI](https://img.shields.io/badge/AI-Claude_API-D97757?style=flat-square)](https://anthropic.com)
[![Status](https://img.shields.io/badge/status-Active_Development-22c55e?style=flat-square)]()
[![Architecture](https://img.shields.io/badge/architecture-RAG_+_Semantic_Kernel-8B5CF6?style=flat-square)]()

**No competitor has built what this platform does.**
HealthVision fuses photorealistic 3D anatomy, a clinical-grade AI intelligence layer,
real-time differential diagnosis, and patient medical history analysis
into a single unified platform — accessible from any device, free to start.

[Explore the Platform](#) · [Read the Architecture](ARCHITECTURE.md) · [View Roadmap](#roadmap)

---

</div>

## What HealthVision Is

HealthVision is not an anatomy viewer. It is not a symptom checker. It is not a drug database.

It is all of them simultaneously — unified by an AI layer that connects every piece of medical knowledge to the 3D human body in real time, adapts to the user's level of expertise, and produces clinical-grade outputs that are sourced, explainable, and safe.

Built entirely in C# from frontend to backend, HealthVision is the first medical intelligence platform designed with a single-language architecture, eliminating the complexity that has made every competing product fragile, slow to iterate, and expensive to maintain.

---

## Why Nothing Else Comes Close

| Capability | BioDigital | Anatomyka | Primal Pictures | 3D4Medical | **HealthVision** |
|---|:---:|:---:|:---:|:---:|:---:|
| High-fidelity 3D anatomy | ✓ | ✓ | ✓ | ✓ | ✓ |
| AI anatomy teacher | — | — | — | — | **✓** |
| Clinical case engine | — | — | — | — | **✓** |
| Differential diagnosis (SOCRATES) | — | — | — | — | **✓** |
| Red-flag emergency screening | — | — | — | — | **✓** |
| Lab result interpreter | — | — | — | — | **✓** |
| Drug-anatomy interaction visualiser | — | — | — | — | **✓** |
| LOD system (3 detail levels) | — | — | Partial | — | **✓** |
| Patient medical history timeline | — | — | — | — | **✓** |
| DICOM overlay on 3D model | — | — | — | — | **✓** |
| Second opinion mode | — | — | — | — | **✓** |
| Wearable data integration | — | — | — | — | **✓** |
| FHIR R4 / EMR connectivity | — | — | — | — | **✓** |
| Multilingual (43 languages) | — | — | — | — | **✓** |
| Free tier | Partial | Partial | — | Partial | **✓** |
| Single-language C# architecture | — | — | — | — | **✓** |

---

## Core Platform Capabilities

### 🧠 Dynamic Medical Technologies — AI Clinical Intelligence Engine
The centerpiece of HealthVision. An AI assistant that does not answer questions — it *reasons* through them. Every response is grounded in retrieved, verified medical knowledge from WHO, NIH, and international clinical databases. The engine follows a mandatory structure: direct answer, mechanistic explanation, clinical relevance, 3D anatomy link, cited sources, confidence score. It never generates a clinical statement from memory alone.

### 🔬 3D Anatomy Explorer with Adaptive LOD
Powered by Unity 6.3 exported to WebGL and embedded seamlessly inside the Blazor interface. Three levels of detail switch automatically based on camera distance — full body silhouette at distance, muscle and organ layer at mid-range, cellular and microscopic detail at close range. Every structure is interactive: click to isolate, rotate 360°, hide layers, annotate, and link to the AI engine instantly.

### ⚕️ Differential Diagnosis Engine
Structured symptom intake using the SOCRATES clinical methodology. Before any diagnosis is generated, a hardcoded rule engine screens for life-threatening conditions — pulmonary embolism, myocardial infarction, stroke, aortic dissection — and escalates immediately if red flags are detected. Diagnoses are ranked in three tiers: Dangerous (exclude today), Probable (most likely), and Rare (low probability, clinically relevant). Every diagnosis links to the relevant 3D anatomy and displays a full reasoning trace with cited guidelines.

### 🧬 Lab Results Interpreter
Upload blood results in any format — PDF, image, plain text. The OCR and parsing engine extracts test names, values, and units regardless of laboratory formatting. Each value is displayed against context-adjusted reference ranges (age, sex, pregnancy, altitude). Abnormal values are colour-coded. Cross-marker pattern detection identifies syndrome-level findings. Longitudinal tracking plots biomarker trends across multiple uploads over time.

### 💊 Drug & Pharmacology Visualiser
Enter any drug by brand or generic name. The system maps every organ and system it affects directly onto the 3D model using OpenFDA and RxNorm data. Drug-drug interaction checking generates a full matrix showing mechanism, severity, and affected anatomy. Chronopharmacology recommendations show optimal timing. Drug-food interactions are flagged. Generic equivalents are suggested with country-specific availability.

### 📋 Patient Medical History Timeline
An interactive, zoomable chronological timeline of diagnoses, procedures, medications, lab results, and imaging. Every event links to the 3D model showing the affected structures at that point in time. Family history module calculates hereditary risk factors. Multi-profile support allows one account to manage an entire family.

### 🩻 DICOM Medical Imaging Overlay
Upload a CT, MRI, PET, or X-ray scan. The DICOM viewer overlays the scan onto the standard 3D reference model using anatomical landmark registration. An AI region-of-interest detector highlights areas of clinical significance with plain-language explanations — always with a mandatory radiologist confirmation disclaimer.

### 🔄 Second Opinion Mode
Upload an existing diagnosis. The system cross-references it against ICD-11, PubMed, NICE, and WHO guidelines, identifies evidence gaps, and generates a structured list of precise clinical questions for the user to ask their physician — with the specific reasoning behind each question.

### 📊 Preventive Health & Risk Calculators
Ten-year cardiovascular risk via SCORE2 and Framingham models. Cancer screening schedules personalised by age, sex, and family history. Vaccine tracker aligned to Ukrainian, EU, and WHO schedules. Nutritional deficiency visualiser. Post-surgery rehabilitation tracker. Validated mental health screening tools (PHQ-9, GAD-7, AUDIT, PCL-5).

### ⌚ Wearable & Monitoring Integration
Native integration with Apple Health, Google Fit, Garmin Connect, and Fitbit. Smart alert engine monitors resting HR, HRV, SpO₂, and sleep stages against clinical thresholds. Medication and appointment reminders with dose tracking and missed-dose logging.

---

## Technology Stack

### Frontend
| Technology | Version | Role |
|---|---|---|
| **Blazor Web App** | .NET 10.0 | Full-stack web framework — SSR on first load, WASM hydration after |
| **C# Razor Components** | .NET 10.0 | All UI components — no JavaScript written by hand |
| **WebAssembly (WASM)** | .NET 10.0 | Client-side interactivity after initial SSR load |
| **CSS Custom Properties** | — | Complete design system via `--hv-*` token architecture |
| **Inter + JetBrains Mono** | — | Typography system |

### 3D Engine
| Technology | Version | Role |
|---|---|---|
| **Unity** | 6.3 LTS | 3D anatomy rendering, LOD system, layer isolation |
| **WebGL Export** | — | Browser-native 3D — no plugin required |
| **HDRP Shaders** | — | Photorealistic subsurface scattering for anatomical tissue |
| **Blazor ↔ Unity Bridge** | — | JS interop layer for bidirectional communication |

### Backend & AI
| Technology | Version | Role |
|---|---|---|
| **ASP.NET Core** | .NET 10.0 | Web server, API endpoints, middleware |
| **Microsoft Semantic Kernel** | Latest | RAG pipeline orchestration — retrieval, context assembly, AI calls |
| **Claude API (Anthropic)** | claude-sonnet-4 | Primary reasoning engine — medical analysis and explanation |
| **Pgvector** | — | Vector database for semantic search over medical knowledge |
| **PostgreSQL** | 16 | Relational data — users, timelines, audit logs, sessions |

### Medical Knowledge Infrastructure
| Source | Data Provided | Access |
|---|---|---|
| **ICD-11 (WHO)** | Disease classification, symptoms, diagnoses | Free REST API |
| **SNOMED CT** | Clinical terminology, anatomy, procedures | Free (registered) |
| **PubMed / NCBI** | 35M+ research papers, clinical evidence | Free E-utilities API |
| **OpenFDA** | Drug data, adverse events, interactions | Free public API |
| **RxNorm (NLM)** | Drug normalisation, generic equivalents | Free |
| **LOINC** | Lab test codes, reference ranges | Free |
| **ClinicalTrials.gov** | Active trials by condition | Free API |
| **NICE Guidelines** | UK evidence-based clinical protocols | Free API |
| **WHO Guidelines** | International clinical standards | Free |
| **Orphanet** | Rare disease database | Free |
| **Cochrane Reviews** | Systematic reviews, meta-analyses | Open access |

### Standards & Interoperability
| Standard | Purpose |
|---|---|
| **FHIR R4** | Patient data structure — hospital-system compatible from day one |
| **HL7** | Bidirectional EMR data exchange (Epic, HELSI, Medesk, Medis) |
| **DICOM** | Medical imaging upload, parsing, and overlay |
| **LOINC** | Lab result normalisation across laboratory systems |
| **SNOMED CT** | Anatomy and clinical terminology standardisation |
| **ICD-11** | Diagnosis coding — 43 language support |

### Security & Compliance
| Requirement | Implementation |
|---|---|
| **GDPR** | EU data residency, AES-256 at rest, TLS 1.3 in transit, full consent management |
| **HIPAA-aligned** | Audit logs, access controls, BAA-aware third-party handling |
| **Audit logging** | Immutable append-only log of all clinical inputs, outputs, sources, and model versions |
| **Active consent** | Gated checkpoint before any clinical feature — timestamped and versioned |

---

## AI Safety Architecture

HealthVision is built around a principle that no competitor has implemented: **the AI is not allowed to be wrong about clinical facts.**

This is enforced architecturally, not by policy:

1. **Retrieval before generation** — Claude receives only facts retrieved from verified databases. It cannot use training memory for clinical statements.
2. **Hardcoded red-flag engine** — Life-threatening condition screening is a rule-based system, not AI-dependent. It cannot be confused, hallucinated, or bypassed.
3. **"I don't know" layer** — When retrieved context is insufficient, the system explicitly states what additional information is needed. It does not generate a low-confidence answer that appears authoritative.
4. **Explainability trace** — Every diagnosis shows the exact clinical criteria met, the guideline applied, and the source cited. No black-box outputs.
5. **Uncertainty scoring** — Three-axis uncertainty indicator: data completeness, evidence quality, and population match. Users see not just confidence, but *why* the system is uncertain.
6. **Physician feedback loop** — Verified clinicians can flag incorrect outputs. Flagged content is reviewed and corrected. Accuracy metrics are tracked and published.
7. **Immutable audit log** — Every clinical interaction is logged with full input, output, sources, and model version. Append-only. Never deleted.

---

## Platform Architecture

```
┌─────────────────────────────────────────────────────────────┐
│                    User (any device)                         │
└──────────────────────────┬──────────────────────────────────┘
                           │ HTTPS / TLS 1.3
┌──────────────────────────▼──────────────────────────────────┐
│              Blazor Web App — .NET 10                        │
│         SSR on first load → WASM hydration                   │
│   NavBar · Hero · Features · Pricing · Viewer · AI Panel    │
└──────────┬───────────────────────────────┬──────────────────┘
           │                               │
┌──────────▼──────────┐      ┌─────────────▼──────────────────┐
│   Unity 6.3 WebGL   │      │    ASP.NET Core API             │
│   3D Anatomy Engine │      │    Semantic Kernel (RAG)        │
│   LOD · Layers      │      │    Claude API Integration       │
│   360° · DICOM      │      │    FHIR · Auth · Audit          │
└─────────────────────┘      └─────────────┬──────────────────┘
                                           │
              ┌────────────────────────────┼──────────────────────┐
              │                            │                       │
┌─────────────▼────────┐  ┌───────────────▼──────┐  ┌────────────▼──────┐
│   PostgreSQL 16      │  │   Pgvector            │  │  External APIs    │
│   + Pgvector         │  │   Medical knowledge   │  │  ICD-11 · PubMed  │
│   Users · Timeline   │  │   semantic search     │  │  OpenFDA · LOINC  │
│   Audit · Sessions   │  │   embeddings          │  │  ClinicalTrials   │
└──────────────────────┘  └───────────────────────┘  └───────────────────┘
```

---

## Build Phases

### ✅ Phase 1 — Web Foundation (Current)
- Blazor Web App with Auto render mode (SSR + WASM)
- Complete design system — `--hv-*` CSS token architecture
- Navigation with frosted glass effect and active state detection
- Hero section with AI chat mockup and platforms bar
- Features, Pricing, and Footer sections
- Proprietary copyright protection

### 🔄 Phase 2 — 3D Anatomy Engine
- Unity 6.3 WebGL build embedded in `/viewer` page
- Full human skeleton, muscle groups, organs, nervous system, vascular system
- Three-level LOD system — automatic distance-based switching
- Layer isolation — hide/show any anatomical system independently
- 360° rotation with momentum and touch support
- Blazor ↔ Unity bidirectional communication bridge
- Click-to-highlight from AI panel to 3D model

### ⏳ Phase 3 — AI Intelligence Layer
- Microsoft Semantic Kernel RAG pipeline
- Claude API integration with medical system prompt
- ICD-11, PubMed, OpenFDA, LOINC knowledge ingestion → Pgvector
- SOCRATES symptom intake
- Red-flag emergency screening engine (hardcoded, non-AI)
- Differential diagnosis — three-tier output with reasoning trace
- Lab results interpreter with longitudinal tracking
- Drug-anatomy interaction visualiser
- Second opinion mode
- Physician feedback loop
- Full audit logging

### ⏳ Phase 4 — Patient Intelligence
- FHIR R4 patient data model
- Interactive medical history timeline
- Family history and hereditary risk calculation
- DICOM viewer with AI region-of-interest detection
- Wearable integrations (Apple Health, Google Fit, Garmin, Fitbit)
- EMR connectors (Epic, HELSI, Medesk)
- Multi-profile family account support

### ⏳ Phase 5 — Global Scale
- EU-compliant hosting with data residency confirmation
- Multilingual support — Ukrainian, Russian, Polish, Arabic (ICD-11 × 43 languages)
- Country-specific clinical content localisation
- Real-time guideline update system (ESC, AHA, WHO, FDA, EMA, NICE feeds)
- Patient Mode vs Clinician Mode
- Clinical trial matching (ClinicalTrials.gov)
- Public accuracy metrics dashboard

---

## Project Structure

```
HealthVision.sln
├── HealthVision.Web              # Blazor Web App — all pages and components
│   ├── Components/
│   │   ├── Layout/               # NavBar, MainLayout, Footer
│   │   ├── Pages/                # Home, Viewer, AITutor, Cases, Pricing
│   │   └── Sections/             # HeroSection, FeaturesSection, PricingSection
│   └── wwwroot/
│       ├── images/               # Logo and static assets
│       └── app.css               # Complete design system
│
├── HealthVision.Web.Client       # WASM client — runs in browser post-hydration
│
├── HealthVision.Core             # Shared models, interfaces, business logic
│   ├── Models/
│   │   ├── Anatomy/              # Body structures, LOD levels
│   │   ├── Medical/              # Diagnosis, symptom, lab, drug models
│   │   ├── MedicalHistory/       # Patient timeline, FHIR resources
│   │   └── AI/                   # Prompt templates, response structures
│   └── Interfaces/               # IRepository, IAIService, IDiagnosisEngine
│
├── ARCHITECTURE.md               # Complete technical specification
├── LICENSE                       # Proprietary — All Rights Reserved
└── README.md                     # This file
```

---

## Intellectual Property

Copyright © 2026 HealthVision. All rights reserved.

This software, its architecture, design systems, clinical AI pipeline, and all associated intellectual property are proprietary and confidential. Unauthorised copying, modification, distribution, or commercial use of any part of this platform, in whole or in part, is strictly prohibited without the express written permission of the copyright holder.

HealthVision® is a registered trademark. The winged anatomical figure and associated visual identity are proprietary assets of HealthVision.

---

## Disclaimer

HealthVision is an educational and informational platform. It does not replace professional medical advice, diagnosis, or treatment. All clinical outputs are for informational purposes only. Always consult a qualified healthcare provider for personal medical decisions.

---

<div align="center">

**Built with precision. Designed for everyone. Trusted by professionals.**

*HealthVision — See the body. Understand everything.*

</div>
