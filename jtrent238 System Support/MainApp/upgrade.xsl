<?xml version="1.0" encoding="UTF-8" standalone="no"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2017-09-06T23:27:55" version="1.0">
	<xsl:output encoding="UTF-8" method="xml"/>
	<xsl:template match="/">
		<xsl:copy-of select="processing-instruction() | comment()"/>
		<xsl:choose>
			<xsl:when test="my:myFields">
				<xsl:apply-templates select="my:myFields" mode="_0"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:variable name="var">
					<xsl:element name="my:myFields"/>
				</xsl:variable>
				<xsl:apply-templates select="msxsl:node-set($var)/*" mode="_0"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<xsl:template match="my:myFields" mode="_0">
		<xsl:copy>
			<xsl:element name="my:field2">
				<xsl:copy-of select="my:field2/text()[1]"/>
			</xsl:element>
			<xsl:element name="my:name">
				<xsl:copy-of select="my:name/text()[1]"/>
			</xsl:element>
			<xsl:element name="my:email">
				<xsl:copy-of select="my:email/text()[1]"/>
			</xsl:element>
			<xsl:element name="my:productkey">
				<xsl:copy-of select="my:productkey/text()[1]"/>
			</xsl:element>
			<xsl:element name="my:copyemail">
				<xsl:choose>
					<xsl:when test="my:copyemail/text()[1]">
						<xsl:copy-of select="my:copyemail/text()[1]"/>
					</xsl:when>
					<xsl:otherwise>false</xsl:otherwise>
				</xsl:choose>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>