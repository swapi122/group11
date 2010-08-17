




/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class VuViecManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecManagerBase()
		{
			// Nothing for now.
		}
		
		public VuViecEntity Insert(VuViecEntity _VuViecEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VuViecEntity, true);
			}
			return _VuViecEntity;
		}

		
		public VuViecEntity Insert(Guid Id, string SttvuViec, Guid IdDanhMucTin, string MaRutGon, Guid IdDonViTiepNhan, Guid IdDonViBaoCao, Guid IdDonViBat, DateTime ThoiGianXayRa, DateTime ThoiGianBaoCao, DateTime ThoiGianPhatHien, string NguoiPhatHien, Guid IdNguonPhatHien, Guid IdPhanLoaiTheoChuyenDe, Guid IdPhanLoaiTheoDiaBan, int SoNanNhan, Guid IdTinhChatVuViec, Guid IdKhamPha, Guid IdNguyenNhanXayRa, Guid IdPhuongThucThuDoan, Guid IdPhuongTienGayAn, Guid IdCoToChuc, int SoDoiTuong, DateTime NgayThucHien, DateTime NgayKetThuc, Guid IdDonViXuLy, Guid IdKhoiToVuAn, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, Guid IdThon, string Duong, string SoNha, Guid IdOkhuVuc, Guid IdToDanPho, Guid IdKetQuaXuLy, Guid IdXuLyHanhChinh, string TomTatNoiDung, string TrinhSatBaoCao, Guid IdDanhGiaTin, string TinhTrangKhamPha, Guid IdCapChiDaoXuLyBanDau, Guid IdHinhThucXuLyBanDau, string SoHinhThucXuLyBanDau, DateTime NgayXuLy, DateTime NgayKetLuan, string SoDinhChiTamDinhChi, DateTime NgayDinhChi, string SoBanAn, DateTime NgayBanAn, string SoHoSo, string MaDonVi, DateTime NgayDangKy, string SoDangKy, DateTime NgayNopLuu, DateTime SoNopLuu, string TrangThaiCoToChuc, Guid IdLoaiDiaBan, Guid IdTinhChatLienQuan, string NoiDungLienQuan, string TieuDeVuViec, Guid IdVanDeKhac, Guid IdXuLyKhac, int TongSoBat, int TongSoTamGiam, int TongSoTaiNgoai, int TongSoTruyNa, string NoiDungXuLyKhac, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecEntity _VuViecEntity = new VuViecEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecEntity.Id = Id;
				_VuViecEntity.SttvuViec = SttvuViec;
				_VuViecEntity.IdDanhMucTin = IdDanhMucTin;
				_VuViecEntity.MaRutGon = MaRutGon;
				_VuViecEntity.IdDonViTiepNhan = IdDonViTiepNhan;
				_VuViecEntity.IdDonViBaoCao = IdDonViBaoCao;
				_VuViecEntity.IdDonViBat = IdDonViBat;
				_VuViecEntity.ThoiGianXayRa = ThoiGianXayRa;
				_VuViecEntity.ThoiGianBaoCao = ThoiGianBaoCao;
				_VuViecEntity.ThoiGianPhatHien = ThoiGianPhatHien;
				_VuViecEntity.NguoiPhatHien = NguoiPhatHien;
				_VuViecEntity.IdNguonPhatHien = IdNguonPhatHien;
				_VuViecEntity.IdPhanLoaiTheoChuyenDe = IdPhanLoaiTheoChuyenDe;
				_VuViecEntity.IdPhanLoaiTheoDiaBan = IdPhanLoaiTheoDiaBan;
				_VuViecEntity.SoNanNhan = SoNanNhan;
				_VuViecEntity.IdTinhChatVuViec = IdTinhChatVuViec;
				_VuViecEntity.IdKhamPha = IdKhamPha;
				_VuViecEntity.IdNguyenNhanXayRa = IdNguyenNhanXayRa;
				_VuViecEntity.IdPhuongThucThuDoan = IdPhuongThucThuDoan;
				_VuViecEntity.IdPhuongTienGayAn = IdPhuongTienGayAn;
				_VuViecEntity.IdCoToChuc = IdCoToChuc;
				_VuViecEntity.SoDoiTuong = SoDoiTuong;
				_VuViecEntity.NgayThucHien = NgayThucHien;
				_VuViecEntity.NgayKetThuc = NgayKetThuc;
				_VuViecEntity.IdDonViXuLy = IdDonViXuLy;
				_VuViecEntity.IdKhoiToVuAn = IdKhoiToVuAn;
				_VuViecEntity.IdNuoc = IdNuoc;
				_VuViecEntity.IdTinh = IdTinh;
				_VuViecEntity.IdHuyen = IdHuyen;
				_VuViecEntity.IdXa = IdXa;
				_VuViecEntity.IdThon = IdThon;
				_VuViecEntity.Duong = Duong;
				_VuViecEntity.SoNha = SoNha;
				_VuViecEntity.IdOkhuVuc = IdOkhuVuc;
				_VuViecEntity.IdToDanPho = IdToDanPho;
				_VuViecEntity.IdKetQuaXuLy = IdKetQuaXuLy;
				_VuViecEntity.IdXuLyHanhChinh = IdXuLyHanhChinh;
				_VuViecEntity.TomTatNoiDung = TomTatNoiDung;
				_VuViecEntity.TrinhSatBaoCao = TrinhSatBaoCao;
				_VuViecEntity.IdDanhGiaTin = IdDanhGiaTin;
				_VuViecEntity.TinhTrangKhamPha = TinhTrangKhamPha;
				_VuViecEntity.IdCapChiDaoXuLyBanDau = IdCapChiDaoXuLyBanDau;
				_VuViecEntity.IdHinhThucXuLyBanDau = IdHinhThucXuLyBanDau;
				_VuViecEntity.SoHinhThucXuLyBanDau = SoHinhThucXuLyBanDau;
				_VuViecEntity.NgayXuLy = NgayXuLy;
				_VuViecEntity.NgayKetLuan = NgayKetLuan;
				_VuViecEntity.SoDinhChiTamDinhChi = SoDinhChiTamDinhChi;
				_VuViecEntity.NgayDinhChi = NgayDinhChi;
				_VuViecEntity.SoBanAn = SoBanAn;
				_VuViecEntity.NgayBanAn = NgayBanAn;
				_VuViecEntity.SoHoSo = SoHoSo;
				_VuViecEntity.MaDonVi = MaDonVi;
				_VuViecEntity.NgayDangKy = NgayDangKy;
				_VuViecEntity.SoDangKy = SoDangKy;
				_VuViecEntity.NgayNopLuu = NgayNopLuu;
				_VuViecEntity.SoNopLuu = SoNopLuu;
				_VuViecEntity.TrangThaiCoToChuc = TrangThaiCoToChuc;
				_VuViecEntity.IdLoaiDiaBan = IdLoaiDiaBan;
				_VuViecEntity.IdTinhChatLienQuan = IdTinhChatLienQuan;
				_VuViecEntity.NoiDungLienQuan = NoiDungLienQuan;
				_VuViecEntity.TieuDeVuViec = TieuDeVuViec;
				_VuViecEntity.IdVanDeKhac = IdVanDeKhac;
				_VuViecEntity.IdXuLyKhac = IdXuLyKhac;
				_VuViecEntity.TongSoBat = TongSoBat;
				_VuViecEntity.TongSoTamGiam = TongSoTamGiam;
				_VuViecEntity.TongSoTaiNgoai = TongSoTaiNgoai;
				_VuViecEntity.TongSoTruyNa = TongSoTruyNa;
				_VuViecEntity.NoiDungXuLyKhac = NoiDungXuLyKhac;
				_VuViecEntity.IdNguoiTao = IdNguoiTao;
				_VuViecEntity.NgayTao = NgayTao;
				_VuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecEntity.NgayCapNhat = NgayCapNhat;
				_VuViecEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecEntity, true);
			}
			return _VuViecEntity;
		}

		public VuViecEntity Insert(string SttvuViec, Guid IdDanhMucTin, string MaRutGon, Guid IdDonViTiepNhan, Guid IdDonViBaoCao, Guid IdDonViBat, DateTime ThoiGianXayRa, DateTime ThoiGianBaoCao, DateTime ThoiGianPhatHien, string NguoiPhatHien, Guid IdNguonPhatHien, Guid IdPhanLoaiTheoChuyenDe, Guid IdPhanLoaiTheoDiaBan, int SoNanNhan, Guid IdTinhChatVuViec, Guid IdKhamPha, Guid IdNguyenNhanXayRa, Guid IdPhuongThucThuDoan, Guid IdPhuongTienGayAn, Guid IdCoToChuc, int SoDoiTuong, DateTime NgayThucHien, DateTime NgayKetThuc, Guid IdDonViXuLy, Guid IdKhoiToVuAn, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, Guid IdThon, string Duong, string SoNha, Guid IdOkhuVuc, Guid IdToDanPho, Guid IdKetQuaXuLy, Guid IdXuLyHanhChinh, string TomTatNoiDung, string TrinhSatBaoCao, Guid IdDanhGiaTin, string TinhTrangKhamPha, Guid IdCapChiDaoXuLyBanDau, Guid IdHinhThucXuLyBanDau, string SoHinhThucXuLyBanDau, DateTime NgayXuLy, DateTime NgayKetLuan, string SoDinhChiTamDinhChi, DateTime NgayDinhChi, string SoBanAn, DateTime NgayBanAn, string SoHoSo, string MaDonVi, DateTime NgayDangKy, string SoDangKy, DateTime NgayNopLuu, DateTime SoNopLuu, string TrangThaiCoToChuc, Guid IdLoaiDiaBan, Guid IdTinhChatLienQuan, string NoiDungLienQuan, string TieuDeVuViec, Guid IdVanDeKhac, Guid IdXuLyKhac, int TongSoBat, int TongSoTamGiam, int TongSoTaiNgoai, int TongSoTruyNa, string NoiDungXuLyKhac, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecEntity _VuViecEntity = new VuViecEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecEntity.SttvuViec = SttvuViec;
				_VuViecEntity.IdDanhMucTin = IdDanhMucTin;
				_VuViecEntity.MaRutGon = MaRutGon;
				_VuViecEntity.IdDonViTiepNhan = IdDonViTiepNhan;
				_VuViecEntity.IdDonViBaoCao = IdDonViBaoCao;
				_VuViecEntity.IdDonViBat = IdDonViBat;
				_VuViecEntity.ThoiGianXayRa = ThoiGianXayRa;
				_VuViecEntity.ThoiGianBaoCao = ThoiGianBaoCao;
				_VuViecEntity.ThoiGianPhatHien = ThoiGianPhatHien;
				_VuViecEntity.NguoiPhatHien = NguoiPhatHien;
				_VuViecEntity.IdNguonPhatHien = IdNguonPhatHien;
				_VuViecEntity.IdPhanLoaiTheoChuyenDe = IdPhanLoaiTheoChuyenDe;
				_VuViecEntity.IdPhanLoaiTheoDiaBan = IdPhanLoaiTheoDiaBan;
				_VuViecEntity.SoNanNhan = SoNanNhan;
				_VuViecEntity.IdTinhChatVuViec = IdTinhChatVuViec;
				_VuViecEntity.IdKhamPha = IdKhamPha;
				_VuViecEntity.IdNguyenNhanXayRa = IdNguyenNhanXayRa;
				_VuViecEntity.IdPhuongThucThuDoan = IdPhuongThucThuDoan;
				_VuViecEntity.IdPhuongTienGayAn = IdPhuongTienGayAn;
				_VuViecEntity.IdCoToChuc = IdCoToChuc;
				_VuViecEntity.SoDoiTuong = SoDoiTuong;
				_VuViecEntity.NgayThucHien = NgayThucHien;
				_VuViecEntity.NgayKetThuc = NgayKetThuc;
				_VuViecEntity.IdDonViXuLy = IdDonViXuLy;
				_VuViecEntity.IdKhoiToVuAn = IdKhoiToVuAn;
				_VuViecEntity.IdNuoc = IdNuoc;
				_VuViecEntity.IdTinh = IdTinh;
				_VuViecEntity.IdHuyen = IdHuyen;
				_VuViecEntity.IdXa = IdXa;
				_VuViecEntity.IdThon = IdThon;
				_VuViecEntity.Duong = Duong;
				_VuViecEntity.SoNha = SoNha;
				_VuViecEntity.IdOkhuVuc = IdOkhuVuc;
				_VuViecEntity.IdToDanPho = IdToDanPho;
				_VuViecEntity.IdKetQuaXuLy = IdKetQuaXuLy;
				_VuViecEntity.IdXuLyHanhChinh = IdXuLyHanhChinh;
				_VuViecEntity.TomTatNoiDung = TomTatNoiDung;
				_VuViecEntity.TrinhSatBaoCao = TrinhSatBaoCao;
				_VuViecEntity.IdDanhGiaTin = IdDanhGiaTin;
				_VuViecEntity.TinhTrangKhamPha = TinhTrangKhamPha;
				_VuViecEntity.IdCapChiDaoXuLyBanDau = IdCapChiDaoXuLyBanDau;
				_VuViecEntity.IdHinhThucXuLyBanDau = IdHinhThucXuLyBanDau;
				_VuViecEntity.SoHinhThucXuLyBanDau = SoHinhThucXuLyBanDau;
				_VuViecEntity.NgayXuLy = NgayXuLy;
				_VuViecEntity.NgayKetLuan = NgayKetLuan;
				_VuViecEntity.SoDinhChiTamDinhChi = SoDinhChiTamDinhChi;
				_VuViecEntity.NgayDinhChi = NgayDinhChi;
				_VuViecEntity.SoBanAn = SoBanAn;
				_VuViecEntity.NgayBanAn = NgayBanAn;
				_VuViecEntity.SoHoSo = SoHoSo;
				_VuViecEntity.MaDonVi = MaDonVi;
				_VuViecEntity.NgayDangKy = NgayDangKy;
				_VuViecEntity.SoDangKy = SoDangKy;
				_VuViecEntity.NgayNopLuu = NgayNopLuu;
				_VuViecEntity.SoNopLuu = SoNopLuu;
				_VuViecEntity.TrangThaiCoToChuc = TrangThaiCoToChuc;
				_VuViecEntity.IdLoaiDiaBan = IdLoaiDiaBan;
				_VuViecEntity.IdTinhChatLienQuan = IdTinhChatLienQuan;
				_VuViecEntity.NoiDungLienQuan = NoiDungLienQuan;
				_VuViecEntity.TieuDeVuViec = TieuDeVuViec;
				_VuViecEntity.IdVanDeKhac = IdVanDeKhac;
				_VuViecEntity.IdXuLyKhac = IdXuLyKhac;
				_VuViecEntity.TongSoBat = TongSoBat;
				_VuViecEntity.TongSoTamGiam = TongSoTamGiam;
				_VuViecEntity.TongSoTaiNgoai = TongSoTaiNgoai;
				_VuViecEntity.TongSoTruyNa = TongSoTruyNa;
				_VuViecEntity.NoiDungXuLyKhac = NoiDungXuLyKhac;
				_VuViecEntity.IdNguoiTao = IdNguoiTao;
				_VuViecEntity.NgayTao = NgayTao;
				_VuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecEntity.NgayCapNhat = NgayCapNhat;
				_VuViecEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecEntity, true);
			}
			return _VuViecEntity;
		}

		public bool Update(VuViecEntity _VuViecEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VuViecFields.Id == _VuViecEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VuViecEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VuViecEntity _VuViecEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VuViecEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string SttvuViec, Guid IdDanhMucTin, string MaRutGon, Guid IdDonViTiepNhan, Guid IdDonViBaoCao, Guid IdDonViBat, DateTime ThoiGianXayRa, DateTime ThoiGianBaoCao, DateTime ThoiGianPhatHien, string NguoiPhatHien, Guid IdNguonPhatHien, Guid IdPhanLoaiTheoChuyenDe, Guid IdPhanLoaiTheoDiaBan, int SoNanNhan, Guid IdTinhChatVuViec, Guid IdKhamPha, Guid IdNguyenNhanXayRa, Guid IdPhuongThucThuDoan, Guid IdPhuongTienGayAn, Guid IdCoToChuc, int SoDoiTuong, DateTime NgayThucHien, DateTime NgayKetThuc, Guid IdDonViXuLy, Guid IdKhoiToVuAn, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, Guid IdThon, string Duong, string SoNha, Guid IdOkhuVuc, Guid IdToDanPho, Guid IdKetQuaXuLy, Guid IdXuLyHanhChinh, string TomTatNoiDung, string TrinhSatBaoCao, Guid IdDanhGiaTin, string TinhTrangKhamPha, Guid IdCapChiDaoXuLyBanDau, Guid IdHinhThucXuLyBanDau, string SoHinhThucXuLyBanDau, DateTime NgayXuLy, DateTime NgayKetLuan, string SoDinhChiTamDinhChi, DateTime NgayDinhChi, string SoBanAn, DateTime NgayBanAn, string SoHoSo, string MaDonVi, DateTime NgayDangKy, string SoDangKy, DateTime NgayNopLuu, DateTime SoNopLuu, string TrangThaiCoToChuc, Guid IdLoaiDiaBan, Guid IdTinhChatLienQuan, string NoiDungLienQuan, string TieuDeVuViec, Guid IdVanDeKhac, Guid IdXuLyKhac, int TongSoBat, int TongSoTamGiam, int TongSoTaiNgoai, int TongSoTruyNa, string NoiDungXuLyKhac, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecEntity _VuViecEntity = new VuViecEntity(Id);
				if (adapter.FetchEntity(_VuViecEntity))
				{
				
					_VuViecEntity.SttvuViec = SttvuViec;
					_VuViecEntity.IdDanhMucTin = IdDanhMucTin;
					_VuViecEntity.MaRutGon = MaRutGon;
					_VuViecEntity.IdDonViTiepNhan = IdDonViTiepNhan;
					_VuViecEntity.IdDonViBaoCao = IdDonViBaoCao;
					_VuViecEntity.IdDonViBat = IdDonViBat;
					_VuViecEntity.ThoiGianXayRa = ThoiGianXayRa;
					_VuViecEntity.ThoiGianBaoCao = ThoiGianBaoCao;
					_VuViecEntity.ThoiGianPhatHien = ThoiGianPhatHien;
					_VuViecEntity.NguoiPhatHien = NguoiPhatHien;
					_VuViecEntity.IdNguonPhatHien = IdNguonPhatHien;
					_VuViecEntity.IdPhanLoaiTheoChuyenDe = IdPhanLoaiTheoChuyenDe;
					_VuViecEntity.IdPhanLoaiTheoDiaBan = IdPhanLoaiTheoDiaBan;
					_VuViecEntity.SoNanNhan = SoNanNhan;
					_VuViecEntity.IdTinhChatVuViec = IdTinhChatVuViec;
					_VuViecEntity.IdKhamPha = IdKhamPha;
					_VuViecEntity.IdNguyenNhanXayRa = IdNguyenNhanXayRa;
					_VuViecEntity.IdPhuongThucThuDoan = IdPhuongThucThuDoan;
					_VuViecEntity.IdPhuongTienGayAn = IdPhuongTienGayAn;
					_VuViecEntity.IdCoToChuc = IdCoToChuc;
					_VuViecEntity.SoDoiTuong = SoDoiTuong;
					_VuViecEntity.NgayThucHien = NgayThucHien;
					_VuViecEntity.NgayKetThuc = NgayKetThuc;
					_VuViecEntity.IdDonViXuLy = IdDonViXuLy;
					_VuViecEntity.IdKhoiToVuAn = IdKhoiToVuAn;
					_VuViecEntity.IdNuoc = IdNuoc;
					_VuViecEntity.IdTinh = IdTinh;
					_VuViecEntity.IdHuyen = IdHuyen;
					_VuViecEntity.IdXa = IdXa;
					_VuViecEntity.IdThon = IdThon;
					_VuViecEntity.Duong = Duong;
					_VuViecEntity.SoNha = SoNha;
					_VuViecEntity.IdOkhuVuc = IdOkhuVuc;
					_VuViecEntity.IdToDanPho = IdToDanPho;
					_VuViecEntity.IdKetQuaXuLy = IdKetQuaXuLy;
					_VuViecEntity.IdXuLyHanhChinh = IdXuLyHanhChinh;
					_VuViecEntity.TomTatNoiDung = TomTatNoiDung;
					_VuViecEntity.TrinhSatBaoCao = TrinhSatBaoCao;
					_VuViecEntity.IdDanhGiaTin = IdDanhGiaTin;
					_VuViecEntity.TinhTrangKhamPha = TinhTrangKhamPha;
					_VuViecEntity.IdCapChiDaoXuLyBanDau = IdCapChiDaoXuLyBanDau;
					_VuViecEntity.IdHinhThucXuLyBanDau = IdHinhThucXuLyBanDau;
					_VuViecEntity.SoHinhThucXuLyBanDau = SoHinhThucXuLyBanDau;
					_VuViecEntity.NgayXuLy = NgayXuLy;
					_VuViecEntity.NgayKetLuan = NgayKetLuan;
					_VuViecEntity.SoDinhChiTamDinhChi = SoDinhChiTamDinhChi;
					_VuViecEntity.NgayDinhChi = NgayDinhChi;
					_VuViecEntity.SoBanAn = SoBanAn;
					_VuViecEntity.NgayBanAn = NgayBanAn;
					_VuViecEntity.SoHoSo = SoHoSo;
					_VuViecEntity.MaDonVi = MaDonVi;
					_VuViecEntity.NgayDangKy = NgayDangKy;
					_VuViecEntity.SoDangKy = SoDangKy;
					_VuViecEntity.NgayNopLuu = NgayNopLuu;
					_VuViecEntity.SoNopLuu = SoNopLuu;
					_VuViecEntity.TrangThaiCoToChuc = TrangThaiCoToChuc;
					_VuViecEntity.IdLoaiDiaBan = IdLoaiDiaBan;
					_VuViecEntity.IdTinhChatLienQuan = IdTinhChatLienQuan;
					_VuViecEntity.NoiDungLienQuan = NoiDungLienQuan;
					_VuViecEntity.TieuDeVuViec = TieuDeVuViec;
					_VuViecEntity.IdVanDeKhac = IdVanDeKhac;
					_VuViecEntity.IdXuLyKhac = IdXuLyKhac;
					_VuViecEntity.TongSoBat = TongSoBat;
					_VuViecEntity.TongSoTamGiam = TongSoTamGiam;
					_VuViecEntity.TongSoTaiNgoai = TongSoTaiNgoai;
					_VuViecEntity.TongSoTruyNa = TongSoTruyNa;
					_VuViecEntity.NoiDungXuLyKhac = NoiDungXuLyKhac;
					_VuViecEntity.IdNguoiTao = IdNguoiTao;
					_VuViecEntity.NgayTao = NgayTao;
					_VuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_VuViecEntity.NgayCapNhat = NgayCapNhat;
					_VuViecEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_VuViecEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecEntity _VuViecEntity = new VuViecEntity(Id);
				if (adapter.FetchEntity(_VuViecEntity))
				{
					adapter.DeleteEntity(_VuViecEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VuViecEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySttvuViec(string SttvuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SttvuViec == SttvuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDanhMucTin(Guid IdDanhMucTin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhMucTin == IdDanhMucTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViTiepNhan(Guid IdDonViTiepNhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViTiepNhan == IdDonViTiepNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViBaoCao(Guid IdDonViBaoCao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBaoCao == IdDonViBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViBat(Guid IdDonViBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThoiGianXayRa(DateTime ThoiGianXayRa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianXayRa == ThoiGianXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThoiGianBaoCao(DateTime ThoiGianBaoCao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianBaoCao == ThoiGianBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThoiGianPhatHien(DateTime ThoiGianPhatHien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianPhatHien == ThoiGianPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNguoiPhatHien(string NguoiPhatHien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NguoiPhatHien == NguoiPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguonPhatHien(Guid IdNguonPhatHien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguonPhatHien == IdNguonPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdPhanLoaiTheoChuyenDe(Guid IdPhanLoaiTheoChuyenDe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoChuyenDe == IdPhanLoaiTheoChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdPhanLoaiTheoDiaBan(Guid IdPhanLoaiTheoDiaBan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoDiaBan == IdPhanLoaiTheoDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNanNhan(int SoNanNhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNanNhan == SoNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhChatVuViec(Guid IdTinhChatVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatVuViec == IdTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdKhamPha(Guid IdKhamPha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhamPha == IdKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguyenNhanXayRa(Guid IdNguyenNhanXayRa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguyenNhanXayRa == IdNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdPhuongThucThuDoan(Guid IdPhuongThucThuDoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongThucThuDoan == IdPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdPhuongTienGayAn(Guid IdPhuongTienGayAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongTienGayAn == IdPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdCoToChuc(Guid IdCoToChuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCoToChuc == IdCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoDoiTuong(int SoDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDoiTuong == SoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayThucHien(DateTime NgayThucHien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayThucHien == NgayThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayKetThuc(DateTime NgayKetThuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViXuLy(Guid IdDonViXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdKhoiToVuAn(Guid IdKhoiToVuAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhoiToVuAn == IdKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNuoc(Guid IdNuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinh(Guid IdTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHuyen(Guid IdHuyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXa(Guid IdXa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdThon(Guid IdThon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDuong(string Duong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNha(string SoNha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdToDanPho(Guid IdToDanPho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdKetQuaXuLy(Guid IdKetQuaXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKetQuaXuLy == IdKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXuLyHanhChinh(Guid IdXuLyHanhChinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTomTatNoiDung(string TomTatNoiDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TomTatNoiDung == TomTatNoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrinhSatBaoCao(string TrinhSatBaoCao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrinhSatBaoCao == TrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDanhGiaTin(Guid IdDanhGiaTin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhGiaTin == IdDanhGiaTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTinhTrangKhamPha(string TinhTrangKhamPha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TinhTrangKhamPha == TinhTrangKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdCapChiDaoXuLyBanDau(Guid IdCapChiDaoXuLyBanDau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCapChiDaoXuLyBanDau == IdCapChiDaoXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHinhThucXuLyBanDau(Guid IdHinhThucXuLyBanDau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHinhThucXuLyBanDau == IdHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoHinhThucXuLyBanDau(string SoHinhThucXuLyBanDau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayXuLy(DateTime NgayXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayKetLuan(DateTime NgayKetLuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoDinhChiTamDinhChi(string SoDinhChiTamDinhChi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayDinhChi(DateTime NgayDinhChi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoBanAn(string SoBanAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBanAn(DateTime NgayBanAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoHoSo(string SoHoSo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaDonVi(string MaDonVi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaDonVi == MaDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayDangKy(DateTime NgayDangKy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoDangKy(string SoDangKy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDangKy == SoDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayNopLuu(DateTime NgayNopLuu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayNopLuu == NgayNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNopLuu(DateTime SoNopLuu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThaiCoToChuc(string TrangThaiCoToChuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThaiCoToChuc == TrangThaiCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiDiaBan(Guid IdLoaiDiaBan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdLoaiDiaBan == IdLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhChatLienQuan(Guid IdTinhChatLienQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatLienQuan == IdTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiDungLienQuan(string NoiDungLienQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungLienQuan == NoiDungLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTieuDeVuViec(string TieuDeVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TieuDeVuViec == TieuDeVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVanDeKhac(Guid IdVanDeKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdVanDeKhac == IdVanDeKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXuLyKhac(Guid IdXuLyKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyKhac == IdXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongSoBat(int TongSoBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoBat == TongSoBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongSoTamGiam(int TongSoTamGiam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTamGiam == TongSoTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongSoTaiNgoai(int TongSoTaiNgoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTaiNgoai == TongSoTaiNgoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongSoTruyNa(int TongSoTruyNa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTruyNa == TongSoTruyNa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiDungXuLyKhac(string NoiDungXuLyKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungXuLyKhac == NoiDungXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecEntity", filter);
			}
			return toReturn;
		}
		

		
		public VuViecEntity SelectOne(Guid Id)
		{
			VuViecEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecEntity _VuViecEntity = new VuViecEntity(Id);
				if (adapter.FetchEntity(_VuViecEntity))
				{
					toReturn = _VuViecEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectAllLST()
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, null, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySttvuViecLST(string SttvuViec)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SttvuViec == SttvuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySttvuViecLST_Paged(string SttvuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SttvuViec == SttvuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySttvuViecRDT(string SttvuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SttvuViec == SttvuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySttvuViecRDT_Paged(string SttvuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SttvuViec == SttvuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDanhMucTinLST(Guid IdDanhMucTin)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhMucTin == IdDanhMucTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDanhMucTinLST_Paged(Guid IdDanhMucTin, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhMucTin == IdDanhMucTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanhMucTinRDT(Guid IdDanhMucTin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhMucTin == IdDanhMucTin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanhMucTinRDT_Paged(Guid IdDanhMucTin, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhMucTin == IdDanhMucTin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViTiepNhanLST(Guid IdDonViTiepNhan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViTiepNhan == IdDonViTiepNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViTiepNhanLST_Paged(Guid IdDonViTiepNhan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViTiepNhan == IdDonViTiepNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViTiepNhanRDT(Guid IdDonViTiepNhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViTiepNhan == IdDonViTiepNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViTiepNhanRDT_Paged(Guid IdDonViTiepNhan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViTiepNhan == IdDonViTiepNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViBaoCaoLST(Guid IdDonViBaoCao)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBaoCao == IdDonViBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViBaoCaoLST_Paged(Guid IdDonViBaoCao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBaoCao == IdDonViBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViBaoCaoRDT(Guid IdDonViBaoCao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBaoCao == IdDonViBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViBaoCaoRDT_Paged(Guid IdDonViBaoCao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBaoCao == IdDonViBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViBatLST(Guid IdDonViBat)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViBatLST_Paged(Guid IdDonViBat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViBatRDT(Guid IdDonViBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViBatRDT_Paged(Guid IdDonViBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByThoiGianXayRaLST(DateTime ThoiGianXayRa)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianXayRa == ThoiGianXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByThoiGianXayRaLST_Paged(DateTime ThoiGianXayRa, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianXayRa == ThoiGianXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThoiGianXayRaRDT(DateTime ThoiGianXayRa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianXayRa == ThoiGianXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThoiGianXayRaRDT_Paged(DateTime ThoiGianXayRa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianXayRa == ThoiGianXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByThoiGianBaoCaoLST(DateTime ThoiGianBaoCao)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianBaoCao == ThoiGianBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByThoiGianBaoCaoLST_Paged(DateTime ThoiGianBaoCao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianBaoCao == ThoiGianBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThoiGianBaoCaoRDT(DateTime ThoiGianBaoCao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianBaoCao == ThoiGianBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThoiGianBaoCaoRDT_Paged(DateTime ThoiGianBaoCao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianBaoCao == ThoiGianBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByThoiGianPhatHienLST(DateTime ThoiGianPhatHien)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianPhatHien == ThoiGianPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByThoiGianPhatHienLST_Paged(DateTime ThoiGianPhatHien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianPhatHien == ThoiGianPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThoiGianPhatHienRDT(DateTime ThoiGianPhatHien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianPhatHien == ThoiGianPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThoiGianPhatHienRDT_Paged(DateTime ThoiGianPhatHien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.ThoiGianPhatHien == ThoiGianPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNguoiPhatHienLST(string NguoiPhatHien)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NguoiPhatHien == NguoiPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNguoiPhatHienLST_Paged(string NguoiPhatHien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NguoiPhatHien == NguoiPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNguoiPhatHienRDT(string NguoiPhatHien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NguoiPhatHien == NguoiPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNguoiPhatHienRDT_Paged(string NguoiPhatHien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NguoiPhatHien == NguoiPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguonPhatHienLST(Guid IdNguonPhatHien)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguonPhatHien == IdNguonPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguonPhatHienLST_Paged(Guid IdNguonPhatHien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguonPhatHien == IdNguonPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguonPhatHienRDT(Guid IdNguonPhatHien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguonPhatHien == IdNguonPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguonPhatHienRDT_Paged(Guid IdNguonPhatHien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguonPhatHien == IdNguonPhatHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhanLoaiTheoChuyenDeLST(Guid IdPhanLoaiTheoChuyenDe)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoChuyenDe == IdPhanLoaiTheoChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhanLoaiTheoChuyenDeLST_Paged(Guid IdPhanLoaiTheoChuyenDe, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoChuyenDe == IdPhanLoaiTheoChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhanLoaiTheoChuyenDeRDT(Guid IdPhanLoaiTheoChuyenDe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoChuyenDe == IdPhanLoaiTheoChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhanLoaiTheoChuyenDeRDT_Paged(Guid IdPhanLoaiTheoChuyenDe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoChuyenDe == IdPhanLoaiTheoChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhanLoaiTheoDiaBanLST(Guid IdPhanLoaiTheoDiaBan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoDiaBan == IdPhanLoaiTheoDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhanLoaiTheoDiaBanLST_Paged(Guid IdPhanLoaiTheoDiaBan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoDiaBan == IdPhanLoaiTheoDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhanLoaiTheoDiaBanRDT(Guid IdPhanLoaiTheoDiaBan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoDiaBan == IdPhanLoaiTheoDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhanLoaiTheoDiaBanRDT_Paged(Guid IdPhanLoaiTheoDiaBan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhanLoaiTheoDiaBan == IdPhanLoaiTheoDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoNanNhanLST(int SoNanNhan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNanNhan == SoNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoNanNhanLST_Paged(int SoNanNhan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNanNhan == SoNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNanNhanRDT(int SoNanNhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNanNhan == SoNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNanNhanRDT_Paged(int SoNanNhan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNanNhan == SoNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdTinhChatVuViecLST(Guid IdTinhChatVuViec)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatVuViec == IdTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdTinhChatVuViecLST_Paged(Guid IdTinhChatVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatVuViec == IdTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhChatVuViecRDT(Guid IdTinhChatVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatVuViec == IdTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhChatVuViecRDT_Paged(Guid IdTinhChatVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatVuViec == IdTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdKhamPhaLST(Guid IdKhamPha)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhamPha == IdKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdKhamPhaLST_Paged(Guid IdKhamPha, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhamPha == IdKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdKhamPhaRDT(Guid IdKhamPha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhamPha == IdKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdKhamPhaRDT_Paged(Guid IdKhamPha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhamPha == IdKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguyenNhanXayRaLST(Guid IdNguyenNhanXayRa)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguyenNhanXayRa == IdNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguyenNhanXayRaLST_Paged(Guid IdNguyenNhanXayRa, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguyenNhanXayRa == IdNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguyenNhanXayRaRDT(Guid IdNguyenNhanXayRa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguyenNhanXayRa == IdNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguyenNhanXayRaRDT_Paged(Guid IdNguyenNhanXayRa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguyenNhanXayRa == IdNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhuongThucThuDoanLST(Guid IdPhuongThucThuDoan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongThucThuDoan == IdPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhuongThucThuDoanLST_Paged(Guid IdPhuongThucThuDoan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongThucThuDoan == IdPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhuongThucThuDoanRDT(Guid IdPhuongThucThuDoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongThucThuDoan == IdPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhuongThucThuDoanRDT_Paged(Guid IdPhuongThucThuDoan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongThucThuDoan == IdPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhuongTienGayAnLST(Guid IdPhuongTienGayAn)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongTienGayAn == IdPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdPhuongTienGayAnLST_Paged(Guid IdPhuongTienGayAn, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongTienGayAn == IdPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhuongTienGayAnRDT(Guid IdPhuongTienGayAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongTienGayAn == IdPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhuongTienGayAnRDT_Paged(Guid IdPhuongTienGayAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdPhuongTienGayAn == IdPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdCoToChucLST(Guid IdCoToChuc)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCoToChuc == IdCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdCoToChucLST_Paged(Guid IdCoToChuc, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCoToChuc == IdCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdCoToChucRDT(Guid IdCoToChuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCoToChuc == IdCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdCoToChucRDT_Paged(Guid IdCoToChuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCoToChuc == IdCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoDoiTuongLST(int SoDoiTuong)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDoiTuong == SoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoDoiTuongLST_Paged(int SoDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDoiTuong == SoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoDoiTuongRDT(int SoDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDoiTuong == SoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoDoiTuongRDT_Paged(int SoDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDoiTuong == SoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayThucHienLST(DateTime NgayThucHien)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayThucHien == NgayThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayThucHienLST_Paged(DateTime NgayThucHien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayThucHien == NgayThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayThucHienRDT(DateTime NgayThucHien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayThucHien == NgayThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayThucHienRDT_Paged(DateTime NgayThucHien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayThucHien == NgayThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayKetThucLST(DateTime NgayKetThuc)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayKetThucLST_Paged(DateTime NgayKetThuc, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetThucRDT(DateTime NgayKetThuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetThucRDT_Paged(DateTime NgayKetThuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViXuLyLST(Guid IdDonViXuLy)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDonViXuLyLST_Paged(Guid IdDonViXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViXuLyRDT(Guid IdDonViXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViXuLyRDT_Paged(Guid IdDonViXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdKhoiToVuAnLST(Guid IdKhoiToVuAn)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhoiToVuAn == IdKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdKhoiToVuAnLST_Paged(Guid IdKhoiToVuAn, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhoiToVuAn == IdKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdKhoiToVuAnRDT(Guid IdKhoiToVuAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhoiToVuAn == IdKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdKhoiToVuAnRDT_Paged(Guid IdKhoiToVuAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKhoiToVuAn == IdKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNuocLST(Guid IdNuoc)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNuocLST_Paged(Guid IdNuoc, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNuocRDT(Guid IdNuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNuocRDT_Paged(Guid IdNuoc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdTinhLST(Guid IdTinh)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdTinhLST_Paged(Guid IdTinh, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhRDT(Guid IdTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhRDT_Paged(Guid IdTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdHuyenLST(Guid IdHuyen)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdHuyenLST_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT(Guid IdHuyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdXaLST(Guid IdXa)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdXaLST_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT(Guid IdXa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdThonLST(Guid IdThon)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdThonLST_Paged(Guid IdThon, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdThonRDT(Guid IdThon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdThonRDT_Paged(Guid IdThon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByDuongLST(string Duong)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByDuongLST_Paged(string Duong, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT(string Duong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT_Paged(string Duong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoNhaLST(string SoNha)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoNhaLST_Paged(string SoNha, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT(string SoNha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT_Paged(string SoNha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdOkhuVucLST(Guid IdOkhuVuc)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdOkhuVucLST_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT(Guid IdOkhuVuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdToDanPhoLST(Guid IdToDanPho)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdToDanPhoLST_Paged(Guid IdToDanPho, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdToDanPhoRDT(Guid IdToDanPho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdToDanPhoRDT_Paged(Guid IdToDanPho, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdKetQuaXuLyLST(Guid IdKetQuaXuLy)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKetQuaXuLy == IdKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdKetQuaXuLyLST_Paged(Guid IdKetQuaXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKetQuaXuLy == IdKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdKetQuaXuLyRDT(Guid IdKetQuaXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKetQuaXuLy == IdKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdKetQuaXuLyRDT_Paged(Guid IdKetQuaXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdKetQuaXuLy == IdKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdXuLyHanhChinhLST(Guid IdXuLyHanhChinh)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdXuLyHanhChinhLST_Paged(Guid IdXuLyHanhChinh, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyHanhChinhRDT(Guid IdXuLyHanhChinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyHanhChinhRDT_Paged(Guid IdXuLyHanhChinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTomTatNoiDungLST(string TomTatNoiDung)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TomTatNoiDung == TomTatNoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTomTatNoiDungLST_Paged(string TomTatNoiDung, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TomTatNoiDung == TomTatNoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTomTatNoiDungRDT(string TomTatNoiDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TomTatNoiDung == TomTatNoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTomTatNoiDungRDT_Paged(string TomTatNoiDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TomTatNoiDung == TomTatNoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTrinhSatBaoCaoLST(string TrinhSatBaoCao)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrinhSatBaoCao == TrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTrinhSatBaoCaoLST_Paged(string TrinhSatBaoCao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrinhSatBaoCao == TrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrinhSatBaoCaoRDT(string TrinhSatBaoCao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrinhSatBaoCao == TrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrinhSatBaoCaoRDT_Paged(string TrinhSatBaoCao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrinhSatBaoCao == TrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDanhGiaTinLST(Guid IdDanhGiaTin)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhGiaTin == IdDanhGiaTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdDanhGiaTinLST_Paged(Guid IdDanhGiaTin, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhGiaTin == IdDanhGiaTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanhGiaTinRDT(Guid IdDanhGiaTin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhGiaTin == IdDanhGiaTin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanhGiaTinRDT_Paged(Guid IdDanhGiaTin, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdDanhGiaTin == IdDanhGiaTin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTinhTrangKhamPhaLST(string TinhTrangKhamPha)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TinhTrangKhamPha == TinhTrangKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTinhTrangKhamPhaLST_Paged(string TinhTrangKhamPha, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TinhTrangKhamPha == TinhTrangKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTinhTrangKhamPhaRDT(string TinhTrangKhamPha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TinhTrangKhamPha == TinhTrangKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTinhTrangKhamPhaRDT_Paged(string TinhTrangKhamPha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TinhTrangKhamPha == TinhTrangKhamPha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdCapChiDaoXuLyBanDauLST(Guid IdCapChiDaoXuLyBanDau)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCapChiDaoXuLyBanDau == IdCapChiDaoXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdCapChiDaoXuLyBanDauLST_Paged(Guid IdCapChiDaoXuLyBanDau, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCapChiDaoXuLyBanDau == IdCapChiDaoXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdCapChiDaoXuLyBanDauRDT(Guid IdCapChiDaoXuLyBanDau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCapChiDaoXuLyBanDau == IdCapChiDaoXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdCapChiDaoXuLyBanDauRDT_Paged(Guid IdCapChiDaoXuLyBanDau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdCapChiDaoXuLyBanDau == IdCapChiDaoXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdHinhThucXuLyBanDauLST(Guid IdHinhThucXuLyBanDau)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHinhThucXuLyBanDau == IdHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdHinhThucXuLyBanDauLST_Paged(Guid IdHinhThucXuLyBanDau, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHinhThucXuLyBanDau == IdHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHinhThucXuLyBanDauRDT(Guid IdHinhThucXuLyBanDau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHinhThucXuLyBanDau == IdHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHinhThucXuLyBanDauRDT_Paged(Guid IdHinhThucXuLyBanDau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdHinhThucXuLyBanDau == IdHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoHinhThucXuLyBanDauLST(string SoHinhThucXuLyBanDau)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoHinhThucXuLyBanDauLST_Paged(string SoHinhThucXuLyBanDau, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoHinhThucXuLyBanDauRDT(string SoHinhThucXuLyBanDau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoHinhThucXuLyBanDauRDT_Paged(string SoHinhThucXuLyBanDau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayXuLyLST(DateTime NgayXuLy)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayXuLyLST_Paged(DateTime NgayXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXuLyRDT(DateTime NgayXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXuLyRDT_Paged(DateTime NgayXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayKetLuanLST(DateTime NgayKetLuan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayKetLuanLST_Paged(DateTime NgayKetLuan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetLuanRDT(DateTime NgayKetLuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetLuanRDT_Paged(DateTime NgayKetLuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoDinhChiTamDinhChiLST(string SoDinhChiTamDinhChi)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoDinhChiTamDinhChiLST_Paged(string SoDinhChiTamDinhChi, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoDinhChiTamDinhChiRDT(string SoDinhChiTamDinhChi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoDinhChiTamDinhChiRDT_Paged(string SoDinhChiTamDinhChi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayDinhChiLST(DateTime NgayDinhChi)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayDinhChiLST_Paged(DateTime NgayDinhChi, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDinhChiRDT(DateTime NgayDinhChi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDinhChiRDT_Paged(DateTime NgayDinhChi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoBanAnLST(string SoBanAn)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoBanAnLST_Paged(string SoBanAn, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoBanAnRDT(string SoBanAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoBanAnRDT_Paged(string SoBanAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayBanAnLST(DateTime NgayBanAn)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayBanAnLST_Paged(DateTime NgayBanAn, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBanAnRDT(DateTime NgayBanAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBanAnRDT_Paged(DateTime NgayBanAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoHoSoLST(string SoHoSo)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoHoSoLST_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT(string SoHoSo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByMaDonViLST(string MaDonVi)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaDonVi == MaDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByMaDonViLST_Paged(string MaDonVi, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaDonVi == MaDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaDonViRDT(string MaDonVi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaDonVi == MaDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaDonViRDT_Paged(string MaDonVi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.MaDonVi == MaDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayDangKyLST(DateTime NgayDangKy)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayDangKyLST_Paged(DateTime NgayDangKy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDangKyRDT(DateTime NgayDangKy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDangKyRDT_Paged(DateTime NgayDangKy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoDangKyLST(string SoDangKy)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDangKy == SoDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoDangKyLST_Paged(string SoDangKy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDangKy == SoDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoDangKyRDT(string SoDangKy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDangKy == SoDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoDangKyRDT_Paged(string SoDangKy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoDangKy == SoDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayNopLuuLST(DateTime NgayNopLuu)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayNopLuu == NgayNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayNopLuuLST_Paged(DateTime NgayNopLuu, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayNopLuu == NgayNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayNopLuuRDT(DateTime NgayNopLuu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayNopLuu == NgayNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayNopLuuRDT_Paged(DateTime NgayNopLuu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayNopLuu == NgayNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoNopLuuLST(DateTime SoNopLuu)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectBySoNopLuuLST_Paged(DateTime SoNopLuu, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNopLuuRDT(DateTime SoNopLuu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNopLuuRDT_Paged(DateTime SoNopLuu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTrangThaiCoToChucLST(string TrangThaiCoToChuc)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThaiCoToChuc == TrangThaiCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTrangThaiCoToChucLST_Paged(string TrangThaiCoToChuc, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThaiCoToChuc == TrangThaiCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiCoToChucRDT(string TrangThaiCoToChuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThaiCoToChuc == TrangThaiCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiCoToChucRDT_Paged(string TrangThaiCoToChuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThaiCoToChuc == TrangThaiCoToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdLoaiDiaBanLST(Guid IdLoaiDiaBan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdLoaiDiaBan == IdLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdLoaiDiaBanLST_Paged(Guid IdLoaiDiaBan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdLoaiDiaBan == IdLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDiaBanRDT(Guid IdLoaiDiaBan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdLoaiDiaBan == IdLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDiaBanRDT_Paged(Guid IdLoaiDiaBan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdLoaiDiaBan == IdLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdTinhChatLienQuanLST(Guid IdTinhChatLienQuan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatLienQuan == IdTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdTinhChatLienQuanLST_Paged(Guid IdTinhChatLienQuan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatLienQuan == IdTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhChatLienQuanRDT(Guid IdTinhChatLienQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatLienQuan == IdTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhChatLienQuanRDT_Paged(Guid IdTinhChatLienQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdTinhChatLienQuan == IdTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNoiDungLienQuanLST(string NoiDungLienQuan)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungLienQuan == NoiDungLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNoiDungLienQuanLST_Paged(string NoiDungLienQuan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungLienQuan == NoiDungLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungLienQuanRDT(string NoiDungLienQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungLienQuan == NoiDungLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungLienQuanRDT_Paged(string NoiDungLienQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungLienQuan == NoiDungLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTieuDeVuViecLST(string TieuDeVuViec)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TieuDeVuViec == TieuDeVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTieuDeVuViecLST_Paged(string TieuDeVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TieuDeVuViec == TieuDeVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTieuDeVuViecRDT(string TieuDeVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TieuDeVuViec == TieuDeVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTieuDeVuViecRDT_Paged(string TieuDeVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TieuDeVuViec == TieuDeVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdVanDeKhacLST(Guid IdVanDeKhac)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdVanDeKhac == IdVanDeKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdVanDeKhacLST_Paged(Guid IdVanDeKhac, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdVanDeKhac == IdVanDeKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVanDeKhacRDT(Guid IdVanDeKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdVanDeKhac == IdVanDeKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVanDeKhacRDT_Paged(Guid IdVanDeKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdVanDeKhac == IdVanDeKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdXuLyKhacLST(Guid IdXuLyKhac)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyKhac == IdXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdXuLyKhacLST_Paged(Guid IdXuLyKhac, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyKhac == IdXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyKhacRDT(Guid IdXuLyKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyKhac == IdXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyKhacRDT_Paged(Guid IdXuLyKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdXuLyKhac == IdXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoBatLST(int TongSoBat)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoBat == TongSoBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoBatLST_Paged(int TongSoBat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoBat == TongSoBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoBatRDT(int TongSoBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoBat == TongSoBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoBatRDT_Paged(int TongSoBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoBat == TongSoBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoTamGiamLST(int TongSoTamGiam)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTamGiam == TongSoTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoTamGiamLST_Paged(int TongSoTamGiam, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTamGiam == TongSoTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoTamGiamRDT(int TongSoTamGiam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTamGiam == TongSoTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoTamGiamRDT_Paged(int TongSoTamGiam, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTamGiam == TongSoTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoTaiNgoaiLST(int TongSoTaiNgoai)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTaiNgoai == TongSoTaiNgoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoTaiNgoaiLST_Paged(int TongSoTaiNgoai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTaiNgoai == TongSoTaiNgoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoTaiNgoaiRDT(int TongSoTaiNgoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTaiNgoai == TongSoTaiNgoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoTaiNgoaiRDT_Paged(int TongSoTaiNgoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTaiNgoai == TongSoTaiNgoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoTruyNaLST(int TongSoTruyNa)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTruyNa == TongSoTruyNa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTongSoTruyNaLST_Paged(int TongSoTruyNa, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTruyNa == TongSoTruyNa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoTruyNaRDT(int TongSoTruyNa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTruyNa == TongSoTruyNa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoTruyNaRDT_Paged(int TongSoTruyNa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TongSoTruyNa == TongSoTruyNa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNoiDungXuLyKhacLST(string NoiDungXuLyKhac)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungXuLyKhac == NoiDungXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNoiDungXuLyKhacLST_Paged(string NoiDungXuLyKhac, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungXuLyKhac == NoiDungXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungXuLyKhacRDT(string NoiDungXuLyKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungXuLyKhac == NoiDungXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungXuLyKhacRDT_Paged(string NoiDungXuLyKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NoiDungXuLyKhac == NoiDungXuLyKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null);
			}
			return _VuViecCollection;
		}
		
		// Return EntityCollection<VuViecEntity>
		public EntityCollection<VuViecEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecEntity> _VuViecCollection = new EntityCollection<VuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecCollection = new EntityCollection(new VuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
