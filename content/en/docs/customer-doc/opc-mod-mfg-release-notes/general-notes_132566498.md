---
title: "General Notes"
url: 
weight: 1
---
 

**Created by Alvarez Villanueva, Beatriz, last modified on Aug 10, 2022**  

Opcenter Modular Manufacturing: On Premise and On Cloud documentation

` `From the version 2207, Opcenter Modular Manufacturing provides identical documentation for on Premise and on Cloud releases.

Opcenter Modular Manufacturing functionalities - scope

Siemens AG supports solely Opcenter Modular Manufacturing features that are officially documented. 

Any improper use of Opcenter Modular Manufacturing not expressly described in official documentation will not be supported. 

As a result, users must not manually launch any executables installed by  unless explicitly instructed to do so by the Siemens Technical Support Service (TSS) or official Opcenter Modular Manufacturing documentation. Likewise, users must not use any APIs exposed by DLLs installed by Opcenter Modular Manufacturing within custom applications, unless explicitly instructed to do so by the Siemens TSS or official Opcenter Modular Manufacturing documentation.

Moreover, the use of any feature not expressly authorized may compromise the proper functioning of Opcenter Modular Manufacturing : in extreme cases, such behavior may cause the relative software and/or data to become corrupted, with no possibility of recovery.

Integration of third-party Software

Integration of third-party software with Opcenter Modular Manufacturing does not imply that the product supports all the functionalities provided by the former. Likewise, it does not imply that those third-party software functionalities that are supported are feasible in all possible configurations. Only those third-party software functionalities and configurations presented and described in Opcenter Modular Manufacturing documentation are officially supported in conjunction with Opcenter Modular Manufacturing.

Data Protection by Design Aspects of DI SW MOM Products and Solutions

In the course of development of DI SW MOM Products and Solutions, DI SW MOM follows the “Data protection by design” as foreseen in Article 25 of the General Data Protection Regulation (“GDPR”). This means that data protection and privacy issues are taken into account starting from the commencement of product development or solution engineering.
In general, within Siemens, the following processes are implemented:

- Data Protection by Design approach is a part of the principles actively adopted by Siemens and integrated in the secure lifecycle development of products.
- Siemens solutions adopt Threat and Risk Analysis (TRA), a Siemens-wide standardized methodology that is used for product, solution and service business during product development, engineering or service projects. This methodology is intended to support Siemens teams in identifying typical security weaknesses and vulnerabilities, analyzing any threats that might exploit these weaknesses or vulnerabilities and evaluating any resulting risks. 

Specifically for DI SW MOM products and solutions, in all data collection and processing activities that potentially involve personal data in the intended customer use case, DI SW MOM considers appropriate technical and/or organizational measures, with the goal of adequately addressing the data protection principles and safeguarding individual rights.

For Opcenter Modular Manufacturing, the following applies:

- Opcenter Modular Manufacturing has obtained the TÜV SÜD certification of security in the development process (based on IEC 62443-4-1). This standard specifies process requirements for the secure lifecycle development of products used in an Industrial Automation and Control System (IACS). The lifecycle includes:
  - the definition of security requirements;
  - secure design,
  - secure implementation (including coding guidelines), verification and validation,
  - secure defect management, patch management, and product end-of-life.
- The following personal data is processed by the Opcenter Modular Manufacturing solution:
  - Full name
  - Workcenter name (the user logs to)
  - Custom Data: Additional data that can be added by the customer which can contain personal information.
  - Device IP or MAC address (iPad used by supervisor) from which authentication and authorization data are processed. There are no geographical position data).

Specific attention is dedicated to the processing of personal data belonging to special categories, relevant for the purpose of detecting the racial or ethnic origin, political opinions, religious or philosophical beliefs, trade union membership, genetic data, health, sexual orientation or conduct, criminal convictions and offenses or related security measures of the persons concerned. No such personal data is processed by Opcenter Modular Manufacturing.

- The personal data processed by Opcenter Modular Manufacturing is required for Authentication / Authorization, Identification, Diagnostic, Tracking, Analysis and Reporting. Therefore, such personal data processed by  Opcenter Modular Manufacturing cannot be anonymized or pseudonymized. Such data is stored solely for these reasons, as it is necessary to identify authorized operators and record authorized actions.
- Opcenter Modular Manufacturing can be configured in order to adopt hashing and encrypting (at rest and in transit).
- In Opcenter Modular Manufacturing, personal data can be deleted when no longer necessary for the designated purpose. In detail, personal data related to personnel or managed by the Identity Provider can be deleted or updated by the customer, and the solution supports customers to define a retention period according to their needs. On the other hand, personal data may appear in the solution’s data repositories as database’s records, product file and log files, which are necessary for diagnostic or logging purposes. This information generated by Opcenter Modular Manufacturing has different retention periods based on their different purposes: some can be modified (or deleted) directly from the customer, others cannot be modified without the assistance of the Siemens Customer Support Service. The retention and deletion policy is defined by the customer. The customer manages and maintains the related data and specifies the retention period according to their requirement. Whichever policy is chosen by the customer, it should be ascertained that the same policy should be implemented for archive files.
- In Opcenter Modular Manufacturing, there is a provision for custom data, such that the customer can specify self-defined data which may be of a sensitive category.
- Opcenter Modular Manufacturing  apps offer the customer the possibility to add free texts (i.e. via comments) that may include sensitive information.
- Regular review is performed to validate necessity for the purposes for which the personal data was collected and test the design against purpose limitation.

